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
    public class Units : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public Units(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public int ArmorVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldArmor), typeof(System.Int32)); }
        }

        public string ArmorTypeVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldArmorType), typeof(System.String)); }
        }

        public int AttackVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldAttack), typeof(System.Int32)); }
        }

        public int DamageVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldDamage), typeof(System.Int32)); }
        }

        public string DamageTypeVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldDamageType), typeof(System.String)); }
        }

        public int DefenseVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldDefense), typeof(System.Int32)); }
        }

        public string DescriptionVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldDescription), typeof(System.String)); }
        }

        public int HitpointsVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldHitpoints), typeof(System.Int32)); }
        }

        public string ImageVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldImage), typeof(System.String)); }
        }

        public int InitiativeVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(UnitsSchema.FieldInitiative), typeof(System.Int32)); }
        }

        public float MoveSpeedVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(UnitsSchema.FieldMoveSpeed), typeof(System.Single)); }
        }

        public string NameVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldName), typeof(System.String)); }
        }

        public string RaceVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(UnitsSchema.FieldRace), typeof(System.String)); }
        }

        public float SpecialChanceVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(UnitsSchema.FieldSpecialChance), typeof(System.Single)); }
        }

    }
}
