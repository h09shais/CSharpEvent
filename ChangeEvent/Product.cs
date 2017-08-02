namespace ChangeEvent
{
    public class Product
    {
        private string name;
        public string Name
        {
            set
            {
                object old = this.name;
                this.name = value;
                this.OnPropertyChange(new PropertyChangeEventArgs("Name", old, value));
            }
        }
        
        public delegate void PropertyChangeHandler(object sender, PropertyChangeEventArgs data);
        
        public event PropertyChangeHandler PropertyChange;
        
        private void OnPropertyChange(PropertyChangeEventArgs data)
        {
            this.PropertyChange?.Invoke(this, data);
        }
    }
}
