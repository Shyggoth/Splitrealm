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
    public class Heroes : RowBase
    {
#pragma warning disable 0414
		private GameDB m_gameDB = null;
#pragma warning restore 0414

        public Heroes(string key, GameDB gameDB) : base(key) {
			m_gameDB = gameDB;
		}

        public string AbilityVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(HeroesSchema.FieldAbility), typeof(System.String)); }
        }

        public string ImageVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(HeroesSchema.FieldImage), typeof(System.String)); }
        }

        public string NameVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(HeroesSchema.FieldName), typeof(System.String)); }
        }

        public string RaceVal
        {
		    get { return (System.String)Convert.ChangeType(GetValue(HeroesSchema.FieldRace), typeof(System.String)); }
        }

    }
}
