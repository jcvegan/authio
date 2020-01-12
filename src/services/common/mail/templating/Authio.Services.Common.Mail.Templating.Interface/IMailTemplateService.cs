namespace Authio.Services.Common.Mail.Templating.Interface
{
    public interface IMailTemplateService
    {
        string Render(string template);
    }
}