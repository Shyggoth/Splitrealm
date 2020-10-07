using System;
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
    public class GameDB : GameDBBase
    {
        public BattlemapObjectsTable BattlemapObjectsTable
        {
            get { return (BattlemapObjectsTable)Tables[BattlemapObjectsSchema.TableName]; }
        }

        public HeroesTable HeroesTable
        {
            get { return (HeroesTable)Tables[HeroesSchema.TableName]; }
        }

        public PointsOfInterestTable PointsOfInterestTable
        {
            get { return (PointsOfInterestTable)Tables[PointsOfInterestSchema.TableName]; }
        }

        public StructuresTable StructuresTable
        {
            get { return (StructuresTable)Tables[StructuresSchema.TableName]; }
        }

        public TilesTable TilesTable
        {
            get { return (TilesTable)Tables[TilesSchema.TableName]; }
        }

        public UnitsTable UnitsTable
        {
            get { return (UnitsTable)Tables[UnitsSchema.TableName]; }
        }


        public GameDB(string name) : base(name, "Splitrealm") {

			Tables.Add(BattlemapObjectsSchema.TableName, new BattlemapObjectsTable((string key) => { return new BattlemapObjects(key, this); }));
			Tables.Add(HeroesSchema.TableName, new HeroesTable((string key) => { return new Heroes(key, this); }));
			Tables.Add(PointsOfInterestSchema.TableName, new PointsOfInterestTable((string key) => { return new PointsOfInterest(key, this); }));
			Tables.Add(StructuresSchema.TableName, new StructuresTable((string key) => { return new Structures(key, this); }));
			Tables.Add(TilesSchema.TableName, new TilesTable((string key) => { return new Tiles(key, this); }));
			Tables.Add(UnitsSchema.TableName, new UnitsTable((string key) => { return new Units(key, this); }));
        
#if UNITY_EDITOR
            System.Reflection.Assembly editorAssembly = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.StartsWith("GameDBEditorLibrary"));
            var gameDBEditorType = editorAssembly.GetTypes().FirstOrDefault(t => t.Namespace == "GameDBEditorLibrary" && t.FullName.EndsWith(".GameDBEditor"));
            var method = gameDBEditorType.GetMethod("AddRuntimeDB", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            method.Invoke(obj: null, parameters: new [] { this });
#endif
			this.Logger = new UnityLogger();
		}

		
        public Exception Load(string path, bool notify = true) {
            var gameDBResource = UnityEngine.Resources.Load(path) as UnityEngine.TextAsset;

		    if (gameDBResource == null)
		    {
		        return new ArgumentException(string.Format("Failed to load gameDB {0} at path: {1}", Name, path));
		    }

            return Import(gameDBResource.text);
        }

		public class UnityLogger : GameDBLibrary.Logger
		{
			public override void Log(string message)
			{
				UnityEngine.Debug.Log(message);
			}

			public override void LogError(string message)
			{
				UnityEngine.Debug.LogError(message);
			}

			public override void LogException(Exception e)
			{
				UnityEngine.Debug.LogException(e);
			}
        }
    }
}
