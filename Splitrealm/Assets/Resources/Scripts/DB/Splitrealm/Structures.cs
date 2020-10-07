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
    public class Structures : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public Structures(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public float BonusVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(StructuresSchema.FieldBonus), typeof(System.Single)); }
        }

        public int CostVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(StructuresSchema.FieldCost), typeof(System.Int32)); }
        }

        public string DescriptionVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(StructuresSchema.FieldDescription), typeof(System.String)); }
        }

        public float HardnessVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(StructuresSchema.FieldHardness), typeof(System.Single)); }
        }

        public string ImageVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(StructuresSchema.FieldImage), typeof(System.String)); }
        }

        public string NameVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(StructuresSchema.FieldName), typeof(System.String)); }
        }

        public int VisionVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(StructuresSchema.FieldVision), typeof(System.Int32)); }
        }

    }
}
