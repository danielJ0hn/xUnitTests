﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;

namespace xUnitTestProject.Tests
{
    public class BossEnemyShould
    {
        [Fact]  
        public void HaveCorrectPower()
        {
            BossEnemy sut = new BossEnemy();
            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
    }
}
