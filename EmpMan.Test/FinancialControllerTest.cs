using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using EmpMan.Controllers;
using EmpMan.ViewModel.FinancialVMs;
using EmpMan.Model;
using EmpMan.DataAccess;


namespace EmpMan.Test
{
    [TestClass]
    public class FinancialControllerTest
    {
        private FinancialController _controller;
        private string _seed;

        public FinancialControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<FinancialController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search((rv.Model as FinancialListVM).Searcher);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(FinancialVM));

            FinancialVM vm = rv.Model as FinancialVM;
            Financial v = new Financial();
			
            v.date = "z73iL";
            v.Gender = EmpMan.Model.Financial+IOEnum.Out;
            v.Money = 81;
            v.UseFor = "THGwdL68w";
            v.Notes = "nQlvR";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Financial>().Find(v.ID);
				
                Assert.AreEqual(data.date, "z73iL");
                Assert.AreEqual(data.Gender, EmpMan.Model.Financial+IOEnum.Out);
                Assert.AreEqual(data.Money, 81);
                Assert.AreEqual(data.UseFor, "THGwdL68w");
                Assert.AreEqual(data.Notes, "nQlvR");
                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void EditTest()
        {
            Financial v = new Financial();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.date = "z73iL";
                v.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v.Money = 81;
                v.UseFor = "THGwdL68w";
                v.Notes = "nQlvR";
                context.Set<Financial>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(FinancialVM));

            FinancialVM vm = rv.Model as FinancialVM;
            vm.Wtm.DC = new DataContext(_seed, DBTypeEnum.Memory);
            v = new Financial();
            v.ID = vm.Entity.ID;
       		
            v.date = "HeFar";
            v.Gender = EmpMan.Model.Financial+IOEnum.Out;
            v.Money = 4;
            v.UseFor = "E5HjoBBI";
            v.Notes = "5e7Ut";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.date", "");
            vm.FC.Add("Entity.Gender", "");
            vm.FC.Add("Entity.Money", "");
            vm.FC.Add("Entity.UseFor", "");
            vm.FC.Add("Entity.Notes", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Financial>().Find(v.ID);
 				
                Assert.AreEqual(data.date, "HeFar");
                Assert.AreEqual(data.Gender, EmpMan.Model.Financial+IOEnum.Out);
                Assert.AreEqual(data.Money, 4);
                Assert.AreEqual(data.UseFor, "E5HjoBBI");
                Assert.AreEqual(data.Notes, "5e7Ut");
                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            Financial v = new Financial();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.date = "z73iL";
                v.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v.Money = 81;
                v.UseFor = "THGwdL68w";
                v.Notes = "nQlvR";
                context.Set<Financial>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(FinancialVM));

            FinancialVM vm = rv.Model as FinancialVM;
            v = new Financial();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Financial>().Find(v.ID);
                Assert.AreEqual(data, null);
          }

        }


        [TestMethod]
        public void DetailsTest()
        {
            Financial v = new Financial();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.date = "z73iL";
                v.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v.Money = 81;
                v.UseFor = "THGwdL68w";
                v.Notes = "nQlvR";
                context.Set<Financial>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchEditTest()
        {
            Financial v1 = new Financial();
            Financial v2 = new Financial();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.date = "z73iL";
                v1.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v1.Money = 81;
                v1.UseFor = "THGwdL68w";
                v1.Notes = "nQlvR";
                v2.date = "HeFar";
                v2.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v2.Money = 4;
                v2.UseFor = "E5HjoBBI";
                v2.Notes = "5e7Ut";
                context.Set<Financial>().Add(v1);
                context.Set<Financial>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(FinancialBatchVM));

            FinancialBatchVM vm = rv.Model as FinancialBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            
            vm.LinkedVM.date = "LcJ7F8zB";
            vm.LinkedVM.Gender = EmpMan.Model.Financial+IOEnum.In;
            vm.LinkedVM.Money = 1;
            vm.LinkedVM.UseFor = "Lz8Z";
            vm.LinkedVM.Notes = "UtPGeAq";
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("LinkedVM.date", "");
            vm.FC.Add("LinkedVM.Gender", "");
            vm.FC.Add("LinkedVM.Money", "");
            vm.FC.Add("LinkedVM.UseFor", "");
            vm.FC.Add("LinkedVM.Notes", "");
            _controller.DoBatchEdit(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Financial>().Find(v1.ID);
                var data2 = context.Set<Financial>().Find(v2.ID);
 				
                Assert.AreEqual(data1.date, "LcJ7F8zB");
                Assert.AreEqual(data2.date, "LcJ7F8zB");
                Assert.AreEqual(data1.Gender, EmpMan.Model.Financial+IOEnum.In);
                Assert.AreEqual(data2.Gender, EmpMan.Model.Financial+IOEnum.In);
                Assert.AreEqual(data1.Money, 1);
                Assert.AreEqual(data2.Money, 1);
                Assert.AreEqual(data1.UseFor, "Lz8Z");
                Assert.AreEqual(data2.UseFor, "Lz8Z");
                Assert.AreEqual(data1.Notes, "UtPGeAq");
                Assert.AreEqual(data2.Notes, "UtPGeAq");
                Assert.AreEqual(data1.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data1.UpdateTime.Value).Seconds < 10);
                Assert.AreEqual(data2.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data2.UpdateTime.Value).Seconds < 10);
            }
        }


        [TestMethod]
        public void BatchDeleteTest()
        {
            Financial v1 = new Financial();
            Financial v2 = new Financial();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.date = "z73iL";
                v1.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v1.Money = 81;
                v1.UseFor = "THGwdL68w";
                v1.Notes = "nQlvR";
                v2.date = "HeFar";
                v2.Gender = EmpMan.Model.Financial+IOEnum.Out;
                v2.Money = 4;
                v2.UseFor = "E5HjoBBI";
                v2.Notes = "5e7Ut";
                context.Set<Financial>().Add(v1);
                context.Set<Financial>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(FinancialBatchVM));

            FinancialBatchVM vm = rv.Model as FinancialBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Financial>().Find(v1.ID);
                var data2 = context.Set<Financial>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }
        }

        [TestMethod]
        public void ExportTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            IActionResult rv2 = _controller.ExportExcel(rv.Model as FinancialListVM);
            Assert.IsTrue((rv2 as FileContentResult).FileContents.Length > 0);
        }


    }
}
