namespace nothinbutdotnetstore.web.infrastructure
{
    public interface RequestCommand  : ApplicationCommand
    {
        bool can_process(Request request);
    }
}