using RewardsPlus.BlazorWebAssembly.Client.Components.Common;
using RewardsPlus.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using RewardsPlus.BlazorWebAssembly.Client.Shared;
using RewardsPlus.WebApi.Shared.Multitenancy;
using Microsoft.AspNetCore.Components;

namespace RewardsPlus.BlazorWebAssembly.Client.Pages.Authentication;

public partial class ForgotPassword
{
    private readonly ForgotPasswordRequest _forgotPasswordRequest = new();
    private CustomValidation? _customValidation;
    private bool BusySubmitting { get; set; }

    [Inject]
    private IUsersClient UsersClient { get; set; } = default!;

    private string Tenant { get; set; } = MultitenancyConstants.Root.Id;

    private async Task SubmitAsync()
    {
        BusySubmitting = true;

        await ApiHelper.ExecuteCallGuardedAsync(
            () => UsersClient.ForgotPasswordAsync(Tenant, _forgotPasswordRequest),
            Snackbar,
            _customValidation);

        BusySubmitting = false;
    }
}