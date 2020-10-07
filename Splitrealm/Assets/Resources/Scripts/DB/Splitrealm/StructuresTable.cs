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
    public class StructuresTable : TableBase
    {
        public StructuresTable(Func<string, RowBase> rowFactory) : base(StructuresSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { StructuresSchema.FieldBonus, new FieldBase(StructuresSchema.FieldBonus, FieldType.@float, false, null) },
                { StructuresSchema.FieldCost, new FieldBase(StructuresSchema.FieldCost, FieldType.@int, false, null) },
                { StructuresSchema.FieldDescription, new FieldBase(StructuresSchema.FieldDescription, FieldType.@string, false, null) },
                { StructuresSchema.FieldHardness, new FieldBase(StructuresSchema.FieldHardness, FieldType.@float, false, null) },
                { StructuresSchema.FieldImage, new FieldBase(StructuresSchema.FieldImage, FieldType.@string, false, null) },
                { StructuresSchema.FieldName, new FieldBase(StructuresSchema.FieldName, FieldType.@string, false, null) },
                { StructuresSchema.FieldVision, new FieldBase(StructuresSchema.FieldVision, FieldType.@int, false, null) }
            };
        }

        public Structures GetByKey(string key) { return m_data[key] as Structures; }

        public Dictionary<string, Structures> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (Structures)entry.Value); }
    }
}
