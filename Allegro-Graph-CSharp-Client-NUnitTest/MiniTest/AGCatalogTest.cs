﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Allegro_Graph_CSharp_Client.AGClient.Util;
using Allegro_Graph_CSharp_Client.AGClient.Mini;

namespace Allegro_Graph_CSharp_Client_NUnitTest.MiniTest
{
    /// <summary>
    /// 测试AGCatalog类
    /// </summary>
    
    [TestFixture]
    class AGCatalogTest
    {
        private AGServerInfo server;
        private AGCatalog catalog;

        [Test]
        [TestFixtureSetUp]
        public void Init()
        {
            server = new AGServerInfo("http://172.16.2.21:10035", "chainyi", "chainyi123");
            catalog = new AGCatalog(server, "zhishime");
        }

        ///<summary>
        /// 测试构造函数以及同样的参数是否返回同样的对象
        ///<summary>
        [Test]
        public void SameObjectTest()
        {
            string catalogName = "zhishi291";
            AGCatalog catalog1 = new AGCatalog(server,catalogName);
            AGCatalog catalog2 = new AGCatalog(server, catalogName);
            Assert.AreNotSame(catalog1, catalog2);
        }

        /// <summary>
        /// 测试 OpenRepository()
        /// </summary>
        [Test]
        public void OpenRepositoryTest()
        {
            string repName = "zhishi291";
            bool result = catalog.OpenRepository(repName) is AGRepository;
            Assert.IsTrue(result);
        }
    }
}