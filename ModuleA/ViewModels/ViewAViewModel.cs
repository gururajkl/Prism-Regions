using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string text = "View A View Model";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
