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
    public class TilesTable : TableBase
    {
        public TilesTable(Func<string, RowBase> rowFactory) : base(TilesSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { TilesSchema.FieldBuildFactor, new FieldBase(TilesSchema.FieldBuildFactor, FieldType.@float, false, null) },
                { TilesSchema.FieldMoveFactor, new FieldBase(TilesSchema.FieldMoveFactor, FieldType.@float, false, null) },
                { TilesSchema.FieldName, new FieldBase(TilesSchema.FieldName, FieldType.@string, false, null) },
                { TilesSchema.FieldTileDesc, new FieldBase(TilesSchema.FieldTileDesc, FieldType.@string, false, null) },
                { TilesSchema.FieldYieldFactor, new FieldBase(TilesSchema.FieldYieldFactor, FieldType.@float, false, null) }
            };
        }

        public Tiles GetByKey(string key) { return m_data[key] as Tiles; }

        public Dictionary<string, Tiles> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (Tiles)entry.Value); }
    }
}
