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
    public class PointsOfInterest : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public PointsOfInterest(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public int ClaimTimeVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(PointsOfInterestSchema.FieldClaimTime), typeof(System.Int32)); }
        }

        public string ImageVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(PointsOfInterestSchema.FieldImage), typeof(System.String)); }
        }

        public string NameVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(PointsOfInterestSchema.FieldName), typeof(System.String)); }
        }

        public int VisionVal
        {
		    get { return (System.Int32)Convert.ChangeType(GetValue(PointsOfInterestSchema.FieldVision), typeof(System.Int32)); }
        }

    }
}
