using FitnessApp.BOL;
using FitnessApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BLL
{
    public class TrainerBL
    {
        public Trainer AddTrainer(Trainer objTrainerBo)
        {
            return new TrainerDAL().AddTrainer(objTrainerBo);
        }

        public Trainer UpdateTrainer(Trainer objTrainerBo)
        {
            return new TrainerDAL().TrainerUpdate(objTrainerBo);
        }


        public List<Trainer> ShowTrainer()
        {
            return new TrainerDAL().ShowTrainers();
        }
        public Trainer GetTrainer(int id)
        {
            return new TrainerDAL().GetTrainer(id);
        }
        public System.Data.DataTable GetAllTrainerBL(Trainer objTrainerBo)
        {
            return new TrainerDAL().GetTrainers(objTrainerBo);
        }
        public int DeleteTrainerBL(Trainer objTrainerBo)
        {
            return new TrainerDAL().DeleteTrainer(objTrainerBo);
        }
        public int EditTrainerBL(Trainer objTrainerBo)
        {
            return new TrainerDAL().TrainerEdit(objTrainerBo);
        }
        public int TrainerLoginrBL(Trainer objTrainerBo)
        {
            return new TrainerDAL().TrainerLogin(objTrainerBo);
        }
        public int TrainerSignUpBL(Trainer objTrainerBo)
        {
            return new TrainerDAL().TrainerSignUp(objTrainerBo);
        }
    }
}
