namespace BusinessLogic
{
    public interface IEmployeeValidator
    {
        bool ValidateToAdd(DataAccess.Employee NewEmployee, string ProjectName);
        object ValidateToRead(string PUID);
        bool ValidateToModify(string OldPUID, object NewEmploye);
        bool ValidateToDelete(string PUID);
    }
}
