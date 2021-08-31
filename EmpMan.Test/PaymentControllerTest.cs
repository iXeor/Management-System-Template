using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using EmpMan.Controllers;
using EmpMan.ViewModel.PaymentVMs;
using EmpMan.Model;
using EmpMan.DataAccess;


namespace EmpMan.Test
{
    [TestClass]
    public class PaymentControllerTest
    {
        private PaymentController _controller;
        private string _seed;

        public PaymentControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<PaymentController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search((rv.Model as PaymentListVM).Searcher);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(PaymentVM));

            PaymentVM vm = rv.Model as PaymentVM;
            Payment v = new Payment();
			
            v.date = "7cmy8YyT";
            v.Name = "Fa7U1";
            v.pay = "66z";
            v.Notes = "21hHGFX4";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Payment>().Find(v.ID);
				
                Assert.AreEqual(data.date, "7cmy8YyT");
                Assert.AreEqual(data.Name, "Fa7U1");
                Assert.AreEqual(data.pay, "66z");
                Assert.AreEqual(data.Notes, "21hHGFX4");
                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void EditTest()
        {
            Payment v = new Payment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.date = "7cmy8YyT";
                v.Name = "Fa7U1";
                v.pay = "66z";
                v.Notes = "21hHGFX4";
                context.Set<Payment>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(PaymentVM));

            PaymentVM vm = rv.Model as PaymentVM;
            vm.Wtm.DC = new DataContext(_seed, DBTypeEnum.Memory);
            v = new Payment();
            v.ID = vm.Entity.ID;
       		
            v.date = "eJkfyJC";
            v.Name = "8v3UxLwv3";
            v.pay = "KLdrRfoN9";
            v.Notes = "SaY";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.date", "");
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.pay", "");
            vm.FC.Add("Entity.Notes", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Payment>().Find(v.ID);
 				
                Assert.AreEqual(data.date, "eJkfyJC");
                Assert.AreEqual(data.Name, "8v3UxLwv3");
                Assert.AreEqual(data.pay, "KLdrRfoN9");
                Assert.AreEqual(data.Notes, "SaY");
                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            Payment v = new Payment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.date = "7cmy8YyT";
                v.Name = "Fa7U1";
                v.pay = "66z";
                v.Notes = "21hHGFX4";
                context.Set<Payment>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(PaymentVM));

            PaymentVM vm = rv.Model as PaymentVM;
            v = new Payment();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Payment>().Find(v.ID);
                Assert.AreEqual(data, null);
          }

        }


        [TestMethod]
        public void DetailsTest()
        {
            Payment v = new Payment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.date = "7cmy8YyT";
                v.Name = "Fa7U1";
                v.pay = "66z";
                v.Notes = "21hHGFX4";
                context.Set<Payment>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchEditTest()
        {
            Payment v1 = new Payment();
            Payment v2 = new Payment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.date = "7cmy8YyT";
                v1.Name = "Fa7U1";
                v1.pay = "66z";
                v1.Notes = "21hHGFX4";
                v2.date = "eJkfyJC";
                v2.Name = "8v3UxLwv3";
                v2.pay = "KLdrRfoN9";
                v2.Notes = "SaY";
                context.Set<Payment>().Add(v1);
                context.Set<Payment>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(PaymentBatchVM));

            PaymentBatchVM vm = rv.Model as PaymentBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            
            vm.LinkedVM.date = "MQaGqIHj";
            vm.LinkedVM.Name = "zoikIEJ";
            vm.LinkedVM.pay = "c0j";
            vm.LinkedVM.Notes = "N3fDApX";
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("LinkedVM.date", "");
            vm.FC.Add("LinkedVM.Name", "");
            vm.FC.Add("LinkedVM.pay", "");
            vm.FC.Add("LinkedVM.Notes", "");
            _controller.DoBatchEdit(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Payment>().Find(v1.ID);
                var data2 = context.Set<Payment>().Find(v2.ID);
 				
                Assert.AreEqual(data1.date, "MQaGqIHj");
                Assert.AreEqual(data2.date, "MQaGqIHj");
                Assert.AreEqual(data1.Name, "zoikIEJ");
                Assert.AreEqual(data2.Name, "zoikIEJ");
                Assert.AreEqual(data1.pay, "c0j");
                Assert.AreEqual(data2.pay, "c0j");
                Assert.AreEqual(data1.Notes, "N3fDApX");
                Assert.AreEqual(data2.Notes, "N3fDApX");
                Assert.AreEqual(data1.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data1.UpdateTime.Value).Seconds < 10);
                Assert.AreEqual(data2.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data2.UpdateTime.Value).Seconds < 10);
            }
        }


        [TestMethod]
        public void BatchDeleteTest()
        {
            Payment v1 = new Payment();
            Payment v2 = new Payment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.date = "7cmy8YyT";
                v1.Name = "Fa7U1";
                v1.pay = "66z";
                v1.Notes = "21hHGFX4";
                v2.date = "eJkfyJC";
                v2.Name = "8v3UxLwv3";
                v2.pay = "KLdrRfoN9";
                v2.Notes = "SaY";
                context.Set<Payment>().Add(v1);
                context.Set<Payment>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(PaymentBatchVM));

            PaymentBatchVM vm = rv.Model as PaymentBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Payment>().Find(v1.ID);
                var data2 = context.Set<Payment>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }
        }

        [TestMethod]
        public void ExportTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            IActionResult rv2 = _controller.ExportExcel(rv.Model as PaymentListVM);
            Assert.IsTrue((rv2 as FileContentResult).FileContents.Length > 0);
        }


    }
}
