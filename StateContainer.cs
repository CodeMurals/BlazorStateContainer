public class StateContainer
{
    public List<string> MovieList {get; set;} = new List<string>();
 
    public void SetValue(string value)
    {
        MovieList.Add(value);
        NotifyStateChanged();
    }
 
    public event Action? OnChange;
 
    private void NotifyStateChanged() => OnChange?.Invoke();
}