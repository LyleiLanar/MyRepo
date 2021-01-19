namespace MySqlEntityHandler.Classes
{
    /// <summary>
    /// This is the interface for all Entity classes from the DB.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// The model entity will be created in the Database.
        /// </summary>
        void CreateItself();
        /// <summary>
        /// The model entity will be updated in the Database.
        /// </summary>
        void UpdateItself();
        /// <summary>
        /// The model entity will be deleted from the Databse.
        /// </summary>
        void DeleteItself();
        /// <summary>
        /// Some validation must be declare here.
        /// </summary>
        void Validation();

    }
}
