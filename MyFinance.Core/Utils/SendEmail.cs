using FluentEmail.Core;

namespace MyFinance.Core.Utils;

public static class SendEmail
{
    public static async Task Send(IFluentEmail fluentEmail, string email, string body)
    {
        await fluentEmail
            .To(email)
            .Body(body)
            .SendAsync();
    }
}
