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
    public class HeroesTable : TableBase
    {
        public HeroesTable(Func<string, RowBase> rowFactory) : base(HeroesSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { HeroesSchema.FieldAbility, new FieldBase(HeroesSchema.FieldAbility, FieldType.@string, false, null) },
                { HeroesSchema.FieldImage, new FieldBase(HeroesSchema.FieldImage, FieldType.@string, false, null) },
                { HeroesSchema.FieldName, new FieldBase(HeroesSchema.FieldName, FieldType.@string, false, null) },
                { HeroesSchema.FieldRace, new FieldBase(HeroesSchema.FieldRace, FieldType.@string, false, null) }
            };
        }

        public Heroes GetByKey(string key) { return m_data[key] as Heroes; }

        public Dictionary<string, Heroes> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (Heroes)entry.Value); }
    }
}
