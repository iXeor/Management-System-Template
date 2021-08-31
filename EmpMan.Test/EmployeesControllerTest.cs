using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using EmpMan.Controllers;
using EmpMan.ViewModel.EmployeesVMs;
using Endpoint.Models;
using EmpMan.DataAccess;


namespace EmpMan.Test
{
    [TestClass]
    public class EmployeesControllerTest
    {
        private EmployeesController _controller;
        private string _seed;

        public EmployeesControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<EmployeesController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search((rv.Model as EmployeesListVM).Searcher);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(EmployeesVM));

            EmployeesVM vm = rv.Model as EmployeesVM;
            Employees v = new Employees();
			
            v.Elder = "5ZQ";
            v.Age = "ktR";
            v.Email = "2Rrc8Ac";
            v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
            v.CellPhone = "Om6HJbY";
            v.HomePhone = "2sWQZyiXm";
            v.Address = "qESNIWlK8";
            v.ZipCode = "Q2RBc";
            v.EID = "rRHm1Rt2R";
            v.jobs = "odZl";
            v.ITCode = "exhH";
            v.Password = "BzatCPyvV";
            v.Name = "0tU";
            v.IsValid = false;
            v.PhotoId = AddFileAttachment();
            v.TenantCode = "2GT5";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Employees>().Find(v.ID);
				
                Assert.AreEqual(data.Elder, "5ZQ");
                Assert.AreEqual(data.Age, "ktR");
                Assert.AreEqual(data.Email, "2Rrc8Ac");
                Assert.AreEqual(data.Gender, WalkingTec.Mvvm.Core.GenderEnum.Female);
                Assert.AreEqual(data.CellPhone, "Om6HJbY");
                Assert.AreEqual(data.HomePhone, "2sWQZyiXm");
                Assert.AreEqual(data.Address, "qESNIWlK8");
                Assert.AreEqual(data.ZipCode, "Q2RBc");
                Assert.AreEqual(data.EID, "rRHm1Rt2R");
                Assert.AreEqual(data.jobs, "odZl");
                Assert.AreEqual(data.ITCode, "exhH");
                Assert.AreEqual(data.Password, "BzatCPyvV");
                Assert.AreEqual(data.Name, "0tU");
                Assert.AreEqual(data.IsValid, false);
                Assert.AreEqual(data.TenantCode, "2GT5");
                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void EditTest()
        {
            Employees v = new Employees();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.Elder = "5ZQ";
                v.Age = "ktR";
                v.Email = "2Rrc8Ac";
                v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v.CellPhone = "Om6HJbY";
                v.HomePhone = "2sWQZyiXm";
                v.Address = "qESNIWlK8";
                v.ZipCode = "Q2RBc";
                v.EID = "rRHm1Rt2R";
                v.jobs = "odZl";
                v.ITCode = "exhH";
                v.Password = "BzatCPyvV";
                v.Name = "0tU";
                v.IsValid = false;
                v.PhotoId = AddFileAttachment();
                v.TenantCode = "2GT5";
                context.Set<Employees>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(EmployeesVM));

            EmployeesVM vm = rv.Model as EmployeesVM;
            vm.Wtm.DC = new DataContext(_seed, DBTypeEnum.Memory);
            v = new Employees();
            v.ID = vm.Entity.ID;
       		
            v.Elder = "OMw";
            v.Age = "w77";
            v.Email = "e7rQyCTD";
            v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
            v.CellPhone = "VOG";
            v.HomePhone = "qLR";
            v.Address = "Tq2Iu";
            v.ZipCode = "Kkjpim";
            v.EID = "Hq3dISz";
            v.jobs = "jkCFK";
            v.ITCode = "Z47cnj";
            v.Password = "RaJsdVN";
            v.Name = "q6zv";
            v.IsValid = false;
            v.TenantCode = "doi1zX";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.Elder", "");
            vm.FC.Add("Entity.Age", "");
            vm.FC.Add("Entity.Email", "");
            vm.FC.Add("Entity.Gender", "");
            vm.FC.Add("Entity.CellPhone", "");
            vm.FC.Add("Entity.HomePhone", "");
            vm.FC.Add("Entity.Address", "");
            vm.FC.Add("Entity.ZipCode", "");
            vm.FC.Add("Entity.EID", "");
            vm.FC.Add("Entity.jobs", "");
            vm.FC.Add("Entity.ITCode", "");
            vm.FC.Add("Entity.Password", "");
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.IsValid", "");
            vm.FC.Add("Entity.PhotoId", "");
            vm.FC.Add("Entity.TenantCode", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Employees>().Find(v.ID);
 				
                Assert.AreEqual(data.Elder, "OMw");
                Assert.AreEqual(data.Age, "w77");
                Assert.AreEqual(data.Email, "e7rQyCTD");
                Assert.AreEqual(data.Gender, WalkingTec.Mvvm.Core.GenderEnum.Female);
                Assert.AreEqual(data.CellPhone, "VOG");
                Assert.AreEqual(data.HomePhone, "qLR");
                Assert.AreEqual(data.Address, "Tq2Iu");
                Assert.AreEqual(data.ZipCode, "Kkjpim");
                Assert.AreEqual(data.EID, "Hq3dISz");
                Assert.AreEqual(data.jobs, "jkCFK");
                Assert.AreEqual(data.ITCode, "Z47cnj");
                Assert.AreEqual(data.Password, "RaJsdVN");
                Assert.AreEqual(data.Name, "q6zv");
                Assert.AreEqual(data.IsValid, false);
                Assert.AreEqual(data.TenantCode, "doi1zX");
                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            Employees v = new Employees();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.Elder = "5ZQ";
                v.Age = "ktR";
                v.Email = "2Rrc8Ac";
                v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v.CellPhone = "Om6HJbY";
                v.HomePhone = "2sWQZyiXm";
                v.Address = "qESNIWlK8";
                v.ZipCode = "Q2RBc";
                v.EID = "rRHm1Rt2R";
                v.jobs = "odZl";
                v.ITCode = "exhH";
                v.Password = "BzatCPyvV";
                v.Name = "0tU";
                v.IsValid = false;
                v.PhotoId = AddFileAttachment();
                v.TenantCode = "2GT5";
                context.Set<Employees>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(EmployeesVM));

            EmployeesVM vm = rv.Model as EmployeesVM;
            v = new Employees();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Employees>().Find(v.ID);
                Assert.AreEqual(data, null);
          }

        }


        [TestMethod]
        public void DetailsTest()
        {
            Employees v = new Employees();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.Elder = "5ZQ";
                v.Age = "ktR";
                v.Email = "2Rrc8Ac";
                v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v.CellPhone = "Om6HJbY";
                v.HomePhone = "2sWQZyiXm";
                v.Address = "qESNIWlK8";
                v.ZipCode = "Q2RBc";
                v.EID = "rRHm1Rt2R";
                v.jobs = "odZl";
                v.ITCode = "exhH";
                v.Password = "BzatCPyvV";
                v.Name = "0tU";
                v.IsValid = false;
                v.PhotoId = AddFileAttachment();
                v.TenantCode = "2GT5";
                context.Set<Employees>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchEditTest()
        {
            Employees v1 = new Employees();
            Employees v2 = new Employees();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.Elder = "5ZQ";
                v1.Age = "ktR";
                v1.Email = "2Rrc8Ac";
                v1.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v1.CellPhone = "Om6HJbY";
                v1.HomePhone = "2sWQZyiXm";
                v1.Address = "qESNIWlK8";
                v1.ZipCode = "Q2RBc";
                v1.EID = "rRHm1Rt2R";
                v1.jobs = "odZl";
                v1.ITCode = "exhH";
                v1.Password = "BzatCPyvV";
                v1.Name = "0tU";
                v1.IsValid = false;
                v1.PhotoId = AddFileAttachment();
                v1.TenantCode = "2GT5";
                v2.Elder = "OMw";
                v2.Age = "w77";
                v2.Email = "e7rQyCTD";
                v2.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v2.CellPhone = "VOG";
                v2.HomePhone = "qLR";
                v2.Address = "Tq2Iu";
                v2.ZipCode = "Kkjpim";
                v2.EID = "Hq3dISz";
                v2.jobs = "jkCFK";
                v2.ITCode = "Z47cnj";
                v2.Password = "RaJsdVN";
                v2.Name = "q6zv";
                v2.IsValid = false;
                v2.PhotoId = v1.PhotoId; 
                v2.TenantCode = "doi1zX";
                context.Set<Employees>().Add(v1);
                context.Set<Employees>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(EmployeesBatchVM));

            EmployeesBatchVM vm = rv.Model as EmployeesBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            
            vm.LinkedVM.Elder = "k8V";
            vm.LinkedVM.Age = "9qt";
            vm.LinkedVM.Email = "WQY3oU";
            vm.LinkedVM.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
            vm.LinkedVM.CellPhone = "2CXn7F";
            vm.LinkedVM.HomePhone = "3fi";
            vm.LinkedVM.Address = "6nJumT3qP";
            vm.LinkedVM.ZipCode = "9yLTvl";
            vm.LinkedVM.EID = "heYp";
            vm.LinkedVM.jobs = "Qd6h";
            vm.LinkedVM.ITCode = "GsV";
            vm.LinkedVM.Password = "poOxSZ";
            vm.LinkedVM.Name = "DvM";
            vm.LinkedVM.IsValid = true;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("LinkedVM.Elder", "");
            vm.FC.Add("LinkedVM.Age", "");
            vm.FC.Add("LinkedVM.Email", "");
            vm.FC.Add("LinkedVM.Gender", "");
            vm.FC.Add("LinkedVM.CellPhone", "");
            vm.FC.Add("LinkedVM.HomePhone", "");
            vm.FC.Add("LinkedVM.Address", "");
            vm.FC.Add("LinkedVM.ZipCode", "");
            vm.FC.Add("LinkedVM.EID", "");
            vm.FC.Add("LinkedVM.jobs", "");
            vm.FC.Add("LinkedVM.ITCode", "");
            vm.FC.Add("LinkedVM.Password", "");
            vm.FC.Add("LinkedVM.Name", "");
            vm.FC.Add("LinkedVM.IsValid", "");
            _controller.DoBatchEdit(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Employees>().Find(v1.ID);
                var data2 = context.Set<Employees>().Find(v2.ID);
 				
                Assert.AreEqual(data1.Elder, "k8V");
                Assert.AreEqual(data2.Elder, "k8V");
                Assert.AreEqual(data1.Age, "9qt");
                Assert.AreEqual(data2.Age, "9qt");
                Assert.AreEqual(data1.Email, "WQY3oU");
                Assert.AreEqual(data2.Email, "WQY3oU");
                Assert.AreEqual(data1.Gender, WalkingTec.Mvvm.Core.GenderEnum.Female);
                Assert.AreEqual(data2.Gender, WalkingTec.Mvvm.Core.GenderEnum.Female);
                Assert.AreEqual(data1.CellPhone, "2CXn7F");
                Assert.AreEqual(data2.CellPhone, "2CXn7F");
                Assert.AreEqual(data1.HomePhone, "3fi");
                Assert.AreEqual(data2.HomePhone, "3fi");
                Assert.AreEqual(data1.Address, "6nJumT3qP");
                Assert.AreEqual(data2.Address, "6nJumT3qP");
                Assert.AreEqual(data1.ZipCode, "9yLTvl");
                Assert.AreEqual(data2.ZipCode, "9yLTvl");
                Assert.AreEqual(data1.EID, "heYp");
                Assert.AreEqual(data2.EID, "heYp");
                Assert.AreEqual(data1.jobs, "Qd6h");
                Assert.AreEqual(data2.jobs, "Qd6h");
                Assert.AreEqual(data1.ITCode, "GsV");
                Assert.AreEqual(data2.ITCode, "GsV");
                Assert.AreEqual(data1.Password, "poOxSZ");
                Assert.AreEqual(data2.Password, "poOxSZ");
                Assert.AreEqual(data1.Name, "DvM");
                Assert.AreEqual(data2.Name, "DvM");
                Assert.AreEqual(data1.IsValid, true);
                Assert.AreEqual(data2.IsValid, true);
                Assert.AreEqual(data1.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data1.UpdateTime.Value).Seconds < 10);
                Assert.AreEqual(data2.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data2.UpdateTime.Value).Seconds < 10);
            }
        }


        [TestMethod]
        public void BatchDeleteTest()
        {
            Employees v1 = new Employees();
            Employees v2 = new Employees();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.Elder = "5ZQ";
                v1.Age = "ktR";
                v1.Email = "2Rrc8Ac";
                v1.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v1.CellPhone = "Om6HJbY";
                v1.HomePhone = "2sWQZyiXm";
                v1.Address = "qESNIWlK8";
                v1.ZipCode = "Q2RBc";
                v1.EID = "rRHm1Rt2R";
                v1.jobs = "odZl";
                v1.ITCode = "exhH";
                v1.Password = "BzatCPyvV";
                v1.Name = "0tU";
                v1.IsValid = false;
                v1.PhotoId = AddFileAttachment();
                v1.TenantCode = "2GT5";
                v2.Elder = "OMw";
                v2.Age = "w77";
                v2.Email = "e7rQyCTD";
                v2.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                v2.CellPhone = "VOG";
                v2.HomePhone = "qLR";
                v2.Address = "Tq2Iu";
                v2.ZipCode = "Kkjpim";
                v2.EID = "Hq3dISz";
                v2.jobs = "jkCFK";
                v2.ITCode = "Z47cnj";
                v2.Password = "RaJsdVN";
                v2.Name = "q6zv";
                v2.IsValid = false;
                v2.PhotoId = v1.PhotoId; 
                v2.TenantCode = "doi1zX";
                context.Set<Employees>().Add(v1);
                context.Set<Employees>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(EmployeesBatchVM));

            EmployeesBatchVM vm = rv.Model as EmployeesBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Employees>().Find(v1.ID);
                var data2 = context.Set<Employees>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }
        }

        [TestMethod]
        public void ExportTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            IActionResult rv2 = _controller.ExportExcel(rv.Model as EmployeesListVM);
            Assert.IsTrue((rv2 as FileContentResult).FileContents.Length > 0);
        }

        private Guid AddFileAttachment()
        {
            FileAttachment v = new FileAttachment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.FileName = "pAh83pF";
                v.FileExt = "4lTD3F";
                v.Path = "6rhGu7vU";
                v.Length = 53;
                v.SaveMode = "EgVsOJ";
                v.ExtraInfo = "5hcOs2m";
                v.HandlerInfo = "gfKnpaBng";
                context.Set<FileAttachment>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }


    }
}
