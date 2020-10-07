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
    public class Tiles : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public Tiles(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public float BuildFactorVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(TilesSchema.FieldBuildFactor), typeof(System.Single)); }
        }

        public float MoveFactorVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(TilesSchema.FieldMoveFactor), typeof(System.Single)); }
        }

        public string NameVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(TilesSchema.FieldName), typeof(System.String)); }
        }

        public string TileDescVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(TilesSchema.FieldTileDesc), typeof(System.String)); }
        }

        public float YieldFactorVal
        {
		    get { return (System.Single)Convert.ChangeType(GetValue(TilesSchema.FieldYieldFactor), typeof(System.Single)); }
        }

    }
}
