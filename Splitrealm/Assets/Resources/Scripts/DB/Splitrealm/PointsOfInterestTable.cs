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
    public class PointsOfInterestTable : TableBase
    {
        public PointsOfInterestTable(Func<string, RowBase> rowFactory) : base(PointsOfInterestSchema.TableName, KeyType.@string, null, rowFactory) {
            m_fields = new Dictionary<string, FieldBase>() {
                { PointsOfInterestSchema.FieldClaimTime, new FieldBase(PointsOfInterestSchema.FieldClaimTime, FieldType.@int, false, null) },
                { PointsOfInterestSchema.FieldImage, new FieldBase(PointsOfInterestSchema.FieldImage, FieldType.@string, false, null) },
                { PointsOfInterestSchema.FieldName, new FieldBase(PointsOfInterestSchema.FieldName, FieldType.@string, false, null) },
                { PointsOfInterestSchema.FieldVision, new FieldBase(PointsOfInterestSchema.FieldVision, FieldType.@int, false, null) }
            };
        }

        public PointsOfInterest GetByKey(string key) { return m_data[key] as PointsOfInterest; }

        public Dictionary<string, PointsOfInterest> GetRows() { return m_data.ToDictionary(entry => entry.Key, entry => (PointsOfInterest)entry.Value); }
    }
}
