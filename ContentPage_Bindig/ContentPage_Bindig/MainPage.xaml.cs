namespace ContentPage_Bindig;

public partial class MainPage : ContentPage
{
	int count = 0;

  private string m_ClickCount = "not clicked yet";

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		this.ClickCount = $"Clicked {count} times";

    if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

  public string ClickCount
  {
    get => this.m_ClickCount;
    set
    {
      this.m_ClickCount = value;
			OnPropertyChanged();
    }
  }

}

