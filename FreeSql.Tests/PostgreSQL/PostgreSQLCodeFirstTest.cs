using FreeSql.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql.LegacyPostgis;
using NpgsqlTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Xunit;

namespace FreeSql.Tests.PostgreSQL {
	public class PostgreSQLCodeFirstTest {

		[Fact]
		public void AddField() {
			var sql = g.pgsql.CodeFirst.GetComparisonDDLStatements<TopicAddField>();
			g.pgsql.Select<TopicAddField>();

			var id = g.pgsql.Insert<TopicAddField>().AppendData(new TopicAddField { }).ExecuteIdentity();
		}

		[Table(Name = "ccc.TopicAddField", OldName = "TopicAddField")]
		public class TopicAddField {
			[Column(IsIdentity = true)]
			public int Id { get; set; }

			public string name { get; set; } = "xxx";

			public int clicks { get; set; } = 10;
			//public int name { get; set; } = 3000;

			//[Column(DbType = "varchar(200) not null", OldName = "title")]
			//public string title222 { get; set; } = "333";

			//[Column(DbType = "varchar(200) not null")]
			//public string title222333 { get; set; } = "xxx";

			//[Column(DbType = "varchar(100) not null", OldName = "title122333aaa")]
			//public string titleaaa { get; set; } = "fsdf";
		}

		[Fact]
		public void GetComparisonDDLStatements() {

			var sql = g.pgsql.CodeFirst.GetComparisonDDLStatements<TableAllType>();
			g.pgsql.Select<TableAllType>();
		}

		
		[Table(Name = "tb_alltype")]
		class TableAllType {
			[Column(IsIdentity = true, IsPrimary = true)]
			public int Id { get; set; }

			public bool testFieldBool { get; set; }
			public sbyte testFieldSByte { get; set; }
			public short testFieldShort { get; set; }
			public int testFieldInt { get; set; }
			public long testFieldLong { get; set; }
			public byte testFieldByte { get; set; }
			public ushort testFieldUShort { get; set; }
			public uint testFieldUInt { get; set; }
			public ulong testFieldULong { get; set; }
			public double testFieldDouble { get; set; }
			public float testFieldFloat { get; set; }
			public decimal testFieldDecimal { get; set; }
			public TimeSpan testFieldTimeSpan { get; set; }
			public DateTime testFieldDateTime { get; set; }
			public byte[] testFieldBytes { get; set; }
			public string testFieldString { get; set; }
			public Guid testFieldGuid { get; set; }
			public NpgsqlPoint testFieldNpgsqlPoint { get; set; }
			public NpgsqlLine testFieldNpgsqlLine { get; set; }
			public NpgsqlLSeg testFieldNpgsqlLSeg { get; set; }
			public NpgsqlBox testFieldNpgsqlBox { get; set; }
			public NpgsqlPath testFieldNpgsqlPath { get; set; }
			public NpgsqlPolygon testFieldNpgsqlPolygon { get; set; }
			public NpgsqlCircle testFieldNpgsqlCircle { get; set; }
			public (IPAddress Address, int Subnet) testFieldCidr { get; set; }
			public NpgsqlRange<int> testFieldInt4range { get; set; }
			public NpgsqlRange<long> testFieldInt8range { get; set; }
			public NpgsqlRange<decimal> testFieldNumrange { get; set; }
			public NpgsqlRange<DateTime> testFieldTsrange { get; set; }

			public bool? testFieldBoolNullable { get; set; }
			public sbyte? testFieldSByteNullable { get; set; }
			public short? testFieldShortNullable { get; set; }
			public int? testFieldIntNullable { get; set; }
			public long? testFielLongNullable { get; set; }
			public byte? testFieldByteNullable { get; set; }
			public ushort? testFieldUShortNullable { get; set; }
			public uint? testFieldUIntNullable { get; set; }
			public ulong? testFieldULongNullable { get; set; }
			public double? testFieldDoubleNullable { get; set; }
			public float? testFieldFloatNullable { get; set; }
			public decimal? testFieldDecimalNullable { get; set; }
			public TimeSpan? testFieldTimeSpanNullable { get; set; }
			public DateTime? testFieldDateTimeNullable { get; set; }
			public Guid? testFieldGuidNullable { get; set; }
			public NpgsqlPoint? testFieldNpgsqlPointNullable { get; set; }
			public NpgsqlLine? testFieldNpgsqlLineNullable { get; set; }
			public NpgsqlLSeg? testFieldNpgsqlLSegNullable { get; set; }
			public NpgsqlBox? testFieldNpgsqlBoxNullable { get; set; }
			public NpgsqlPath? testFieldNpgsqlPathNullable { get; set; }
			public NpgsqlPolygon? testFieldNpgsqlPolygonNullable { get; set; }
			public NpgsqlCircle? testFieldNpgsqlCircleNullable { get; set; }
			public (IPAddress Address, int Subnet)? testFieldCidrNullable { get; set; }
			public NpgsqlRange<int>? testFieldInt4rangeNullable { get; set; }
			public NpgsqlRange<long>? testFieldInt8rangeNullable { get; set; }
			public NpgsqlRange<decimal>? testFieldNumrangeNullable { get; set; }
			public NpgsqlRange<DateTime>? testFieldTsrangeNullable { get; set; }

			public BitArray testFieldBitArray { get; set; }
			public IPAddress testFieldInet { get; set; }
			public PhysicalAddress testFieldMacaddr { get; set; }
			public JToken testFieldJToken { get; set; }
			public JObject testFieldJObject { get; set; }
			public JArray testFieldJArray { get; set; }
			public Dictionary<string, string> testFieldHStore { get; set; }
			public PostgisPoint testFieldPostgisPoint { get; set; }
			public PostgisLineString testFieldPostgisLineString { get; set; }
			public PostgisPolygon testFieldPostgisPolygon { get; set; }
			public PostgisMultiPoint testFieldPostgisMultiPoint { get; set; }
			public PostgisMultiLineString testFieldPostgisPostgisMultiLineString { get; set; }
			public PostgisMultiPolygon testFieldPostgisPostgisMultiPolygon { get; set; }
			public PostgisGeometry testFieldPostgisGeometry { get; set; }
			public PostgisGeometryCollection testFieldPostgisGeometryCollection { get; set; }

			public TableAllTypeEnumType1 testFieldEnum1 { get; set; }
			public TableAllTypeEnumType1? testFieldEnum1Nullable { get; set; }
			public TableAllTypeEnumType2 testFieldEnum2 { get; set; }
			public TableAllTypeEnumType2? testFieldEnum2Nullable { get; set; }

			/* array */
			public bool[] testFieldBoolArray { get; set; }
			public sbyte[] testFieldSByteArray { get; set; }
			public short[] testFieldShortArray { get; set; }
			public int[] testFieldIntArray { get; set; }
			public long[] testFieldLongArray { get; set; }
			public byte[] testFieldByteArray { get; set; }
			public ushort[] testFieldUShortArray { get; set; }
			public uint[] testFieldUIntArray { get; set; }
			public ulong[] testFieldULongArray { get; set; }
			public double[] testFieldDoubleArray { get; set; }
			public float[] testFieldFloatArray { get; set; }
			public decimal[] testFieldDecimalArray { get; set; }
			public TimeSpan[] testFieldTimeSpanArray { get; set; }
			public DateTime[] testFieldDateTimeArray { get; set; }
			public byte[][] testFieldBytesArray { get; set; }
			public string[] testFieldStringArray { get; set; }
			public Guid[] testFieldGuidArray { get; set; }
			public NpgsqlPoint[] testFieldNpgsqlPointArray { get; set; }
			public NpgsqlLine[] testFieldNpgsqlLineArray { get; set; }
			public NpgsqlLSeg[] testFieldNpgsqlLSegArray { get; set; }
			public NpgsqlBox[] testFieldNpgsqlBoxArray { get; set; }
			public NpgsqlPath[] testFieldNpgsqlPathArray { get; set; }
			public NpgsqlPolygon[] testFieldNpgsqlPolygonArray { get; set; }
			public NpgsqlCircle[] testFieldNpgsqlCircleArray { get; set; }
			public (IPAddress Address, int Subnet)[] testFieldCidrArray { get; set; }
			public NpgsqlRange<int>[] testFieldInt4rangeArray { get; set; }
			public NpgsqlRange<long>[] testFieldInt8rangeArray { get; set; }
			public NpgsqlRange<decimal>[] testFieldNumrangeArray { get; set; }
			public NpgsqlRange<DateTime>[] testFieldTsrangeArray { get; set; }

			public bool?[] testFieldBoolArrayNullable { get; set; }
			public sbyte?[] testFieldSByteArrayNullable { get; set; }
			public short?[] testFieldShortArrayNullable { get; set; }
			public int?[] testFieldIntArrayNullable { get; set; }
			public long?[] testFielLongArrayNullable { get; set; }
			public byte?[] testFieldByteArrayNullable { get; set; }
			public ushort?[] testFieldUShortArrayNullable { get; set; }
			public uint?[] testFieldUIntArrayNullable { get; set; }
			public ulong?[] testFieldULongArrayNullable { get; set; }
			public double?[] testFieldDoubleArrayNullable { get; set; }
			public float?[] testFieldFloatArrayNullable { get; set; }
			public decimal?[] testFieldDecimalArrayNullable { get; set; }
			public TimeSpan?[] testFieldTimeSpanArrayNullable { get; set; }
			public DateTime?[] testFieldDateTimeArrayNullable { get; set; }
			public Guid?[] testFieldGuidArrayNullable { get; set; }
			public NpgsqlPoint?[] testFieldNpgsqlPointArrayNullable { get; set; }
			public NpgsqlLine?[] testFieldNpgsqlLineArrayNullable { get; set; }
			public NpgsqlLSeg?[] testFieldNpgsqlLSegArrayNullable { get; set; }
			public NpgsqlBox?[] testFieldNpgsqlBoxArrayNullable { get; set; }
			public NpgsqlPath?[] testFieldNpgsqlPathArrayNullable { get; set; }
			public NpgsqlPolygon?[] testFieldNpgsqlPolygonArrayNullable { get; set; }
			public NpgsqlCircle?[] testFieldNpgsqlCircleArrayNullable { get; set; }
			public (IPAddress Address, int Subnet)?[] testFieldCidrArrayNullable { get; set; }
			public NpgsqlRange<int>?[] testFieldInt4rangeArrayNullable { get; set; }
			public NpgsqlRange<long>?[] testFieldInt8rangeArrayNullable { get; set; }
			public NpgsqlRange<decimal>?[] testFieldNumrangeArrayNullable { get; set; }
			public NpgsqlRange<DateTime>?[] testFieldTsrangeArrayNullable { get; set; }

			public BitArray[] testFieldBitArrayArray { get; set; }
			public IPAddress[] testFieldInetArray { get; set; }
			public PhysicalAddress[] testFieldMacaddrArray { get; set; }
			public JToken[] testFieldJTokenArray { get; set; }
			public JObject[] testFieldJObjectArray { get; set; }
			public JArray[] testFieldJArrayArray { get; set; }
			public Dictionary<string, string>[] testFieldHStoreArray { get; set; }
			public PostgisPoint[] testFieldPostgisPointArray { get; set; }
			public PostgisLineString[] testFieldPostgisLineStringArray { get; set; }
			public PostgisPolygon[] testFieldPostgisPolygonArray { get; set; }
			public PostgisMultiPoint[] testFieldPostgisMultiPointArray { get; set; }
			public PostgisMultiLineString[] testFieldPostgisPostgisMultiLineStringArray { get; set; }
			public PostgisMultiPolygon[] testFieldPostgisPostgisMultiPolygonArray { get; set; }
			public PostgisGeometry[] testFieldPostgisGeometryArray { get; set; }
			public PostgisGeometryCollection[] testFieldPostgisGeometryCollectionArray { get; set; }

			public TableAllTypeEnumType1[] testFieldEnum1Array { get; set; }
			public TableAllTypeEnumType1?[] testFieldEnum1ArrayNullable { get; set; }
			public TableAllTypeEnumType2[] testFieldEnum2Array { get; set; }
			public TableAllTypeEnumType2?[] testFieldEnum2ArrayNullable { get; set; }
		}

		public enum TableAllTypeEnumType1 { e1, e2, e3, e5 }
		[Flags] public enum TableAllTypeEnumType2 { f1, f2, f3 }
	}
}