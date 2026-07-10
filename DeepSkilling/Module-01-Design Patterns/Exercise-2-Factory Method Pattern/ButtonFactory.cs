public class ButtonFactory
{
    public Button GetButton(string type)
    {
        if (type == "Windows")
            return new WindowsButton();

        return new WebButton();
    }
}