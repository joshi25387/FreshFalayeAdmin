using Microsoft.AspNetCore.Components;
using Radzen;
using System.Net;

namespace FreshFalaye.Admin.Models
{
    public class BasePage : ComponentBase
    {
        [Inject] protected NotificationService NotificationService { get; set; } = null!;

        protected async Task HandleApiResponse(HttpResponseMessage response)
        {
            // Read message sent by API (success or error)
            var message = await response.Content.ReadAsStringAsync();

            // ✅ SUCCESS (200–299)
            if (response.IsSuccessStatusCode)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = string.IsNullOrWhiteSpace(message)
                        ? "Operation completed successfully"
                        : message,
                    Duration = 2000
                });
                return;
            }

            // ❌ BAD REQUEST (business rule violation)
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Error",
                    Detail = string.IsNullOrWhiteSpace(message)
                        ? "Invalid request"
                        : message,
                    Duration = 4000
                });
                return;
            }

            // ❌ NOT FOUND
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Warning,
                    Summary = "Not Found",
                    Detail = string.IsNullOrWhiteSpace(message)
                        ? "Record not found"
                        : message,
                    Duration = 4000
                });
                return;
            }

            // ❌ EVERYTHING ELSE (500, etc.)
            NotificationService.Notify(new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = "Server Error",
                Detail = "Unexpected server error occurred",
                Duration = 4000
            });
        }
    }
}
