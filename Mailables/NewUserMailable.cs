using Coravel.Mailer.Mail;
using ExemploEnvioEmail.Models;

namespace ExemploEnvioEmail.Mailables
{
    public class NewUserMailable: Mailable<NewUserMailableViewModel>
    {
        private NewUserMailableViewModel _newUser;

        public NewUserMailable(NewUserMailableViewModel newUser) => this._newUser = newUser;

        public override void Build()
        {
            this.To(this._newUser)
                .From(new MailRecipient("contato@treinaweb.com.br", "Treinaweb Cursos"))
                .View("~/Views/Mail/NewUser.cshtml", this._newUser);
        }
    }
}