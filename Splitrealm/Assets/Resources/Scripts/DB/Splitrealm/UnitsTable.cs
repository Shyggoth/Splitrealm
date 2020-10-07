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
    public class UnitsTable : TableBase
    {
        public UnitsTable(Func<string, RowBase> rowFactory) : base(UnitsSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { UnitsSchema.FieldArmor, new FieldBase(UnitsSchema.FieldArmor, FieldType.@int, false, null) },
                { UnitsSchema.FieldArmorType, new FieldBase(UnitsSchema.FieldArmorType, FieldType.@string, false, null) },
                { UnitsSchema.FieldAttack, new FieldBase(UnitsSchema.FieldAttack, FieldType.@int, false, null) },
                { UnitsSchema.FieldDamage, new FieldBase(UnitsSchema.FieldDamage, FieldType.@int, false, null) },
                { UnitsSchema.FieldDamageType, new FieldBase(UnitsSchema.FieldDamageType, FieldType.@string, false, null) },
                { UnitsSchema.FieldDefense, new FieldBase(UnitsSchema.FieldDefense, FieldType.@int, false, null) },
                { UnitsSchema.FieldDescription, new FieldBase(UnitsSchema.FieldDescription, FieldType.@string, false, null) },
                { UnitsSchema.FieldHitpoints, new FieldBase(UnitsSchema.FieldHitpoints, FieldType.@int, false, null) },
                { UnitsSchema.FieldImage, new FieldBase(UnitsSchema.FieldImage, FieldType.@string, false, null) },
                { UnitsSchema.FieldInitiative, new FieldBase(UnitsSchema.FieldInitiative, FieldType.@int, false, null) },
                { UnitsSchema.FieldMoveSpeed, new FieldBase(UnitsSchema.FieldMoveSpeed, FieldType.@float, false, null) },
                { UnitsSchema.FieldName, new FieldBase(UnitsSchema.FieldName, FieldType.@string, false, null) },
                { UnitsSchema.FieldRace, new FieldBase(UnitsSchema.FieldRace, FieldType.@string, false, null) },
                { UnitsSchema.FieldSpecialChance, new FieldBase(UnitsSchema.FieldSpecialChance, FieldType.@float, false, null) }
            };
        }

        public Units GetByKey(string key) { return m_data[key] as Units; }

        public Dictionary<string, Units> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (Units)entry.Value); }
    }
}
