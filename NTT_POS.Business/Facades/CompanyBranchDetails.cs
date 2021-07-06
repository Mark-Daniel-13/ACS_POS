using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class CompanyBranchDetails
    {
        public static Models.CompanyBranchDetails ToModel(Data.CompanyBranchDetail branchDetail)
        {
            return new Models.CompanyBranchDetails()
            {
                BranchId = branchDetail.BranchId,
                BranchName = branchDetail.BranchName,
                Address = branchDetail.Address,
                TinNo = branchDetail.TinNo,
                CreationDate = branchDetail.CreationDate,
                EndDate = branchDetail.EndDate,
            };
        }

        public static List<Models.CompanyBranchDetails> ToModelList(List<Data.CompanyBranchDetail> branchDetails)
        {
            var branchList = new List<Models.CompanyBranchDetails>();
            branchList = branchDetails.Select(branchDetail => new Models.CompanyBranchDetails
            {
                BranchId = branchDetail.BranchId,
                BranchName = branchDetail.BranchName,
                Address = branchDetail.Address,
                TinNo = branchDetail.TinNo,
                CreationDate = branchDetail.CreationDate,
                EndDate = branchDetail.EndDate,
            }).ToList();

            return branchList;
        }

        public static List<Models.CompanyBranchDetails> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var branch = db.Fetch<Data.CompanyBranchDetail>("WHERE EndDate IS NULL ORDER BY BranchId Desc");
                if (branch == null) return null;

                return ToModelList(branch);
            }
        }

        public static bool AddBranch(Models.CompanyBranchDetails branch)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbBranchDetail = new Data.CompanyBranchDetail()
                    {
                        BranchName = branch.BranchName,
                        Address = branch.Address,
                        TinNo = branch.TinNo,
                        CreationDate = DateTime.Now
                    };
                    db.Save(dbBranchDetail);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateBranch(Models.CompanyBranchDetails branch)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbBranch = db.FirstOrDefault<Data.CompanyBranchDetail>("WHERE BranchId = @0 AND EndDate IS NULL", branch.BranchId);
                    if (dbBranch == null) return false;

                    if (AddBranch(branch))
                    {
                        dbBranch.EndDate = DateTime.Now;
                        db.Update(dbBranch);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
