using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface  ICommandAPIRepo
    {
         bool SaveChanges();
         IEnumerable<CommandsModel> GetAllCommands();
         CommandsModel GetCommandByID();
         void CreateCommad();
         void DeleteCommand();
         void UpdateCommand();

    }
}