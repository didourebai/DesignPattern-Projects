namespace FactoryMethodPattern.Classes
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Creator
    {
        public abstract Employee FactoryMethod();
    }
}