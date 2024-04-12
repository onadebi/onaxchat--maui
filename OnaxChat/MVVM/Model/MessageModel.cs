namespace OnaxChat.MVVM.Model;

public class MessageModel
{
    public string Username { get; set; }
    public string UsernameColor { get; set; }
    public string ImageSource { get; set; }
    public string Message { get; set; }
    public DateTime TimeOfMessage { get; set; }
    public bool IsNativeOrigin { get; set; }
    public bool? IsFirstMessage { get; set; }
}
