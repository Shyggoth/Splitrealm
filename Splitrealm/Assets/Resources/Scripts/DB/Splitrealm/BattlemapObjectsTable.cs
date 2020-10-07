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
    public class BattlemapObjectsTable : TableBase
    {
        public BattlemapObjectsTable(Func<string, RowBase> rowFactory) : base(BattlemapObjectsSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { BattlemapObjectsSchema.FieldAttackBonus, new FieldBase(BattlemapObjectsSchema.FieldAttackBonus, FieldType.@float, false, null) },
                { BattlemapObjectsSchema.FieldDefenseBonus, new FieldBase(BattlemapObjectsSchema.FieldDefenseBonus, FieldType.@float, false, null) },
                { BattlemapObjectsSchema.FieldImage, new FieldBase(BattlemapObjectsSchema.FieldImage, FieldType.@string, true, null) },
                { BattlemapObjectsSchema.FieldMoveFactor, new FieldBase(BattlemapObjectsSchema.FieldMoveFactor, FieldType.@float, false, null) }
            };
        }

        public BattlemapObjects GetByKey(string key) { return m_data[key] as BattlemapObjects; }

        public Dictionary<string, BattlemapObjects> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (BattlemapObjects)entry.Value); }
    }
}
