using SignalR.Hubs;


namespace SignalRExemplo01.Hubs
{
    public class Chat : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {
            Clients.TransmitirMensagem(apelido, mensagem);
        }
    }
}