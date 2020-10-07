using System;
using System.Collections.Generic;
using System.Linq;
using GameDBLibrary;


/**************************************************************************************
*
*
*                     THIS IS A GENERATED FILE! DO NOT EDIT!
*
*
**************************************************************************************/

namespace GameDBSplitrealm
{
    public class BattlemapObjects : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public BattlemapObjects(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public float AttackBonusVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(BattlemapObjectsSchema.FieldAttackBonus), typeof(System.Single)); }
        }

        public float DefenseBonusVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(BattlemapObjectsSchema.FieldDefenseBonus), typeof(System.Single)); }
        }

        public List<string> ImageVal
        {
		    get { return (GetValue(BattlemapObjectsSchema.FieldImage) as List<object>).Select(objVal => (System.String)Convert.ChangeType(objVal, typeof(System.String))).ToList(); }
        }

        public float MoveFactorVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(BattlemapObjectsSchema.FieldMoveFactor), typeof(System.Single)); }
        }

    }
}
