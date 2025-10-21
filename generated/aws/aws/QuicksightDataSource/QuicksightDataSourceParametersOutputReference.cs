using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSource.QuicksightDataSourceParametersOutputReference), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSourceParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSourceParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmazonElasticsearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearch\"}}]")]
        public virtual void PutAmazonElasticsearch(aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAthena", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthena\"}}]")]
        public virtual void PutAthena(aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAurora", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAurora\"}}]")]
        public virtual void PutAurora(aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuroraPostgresql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresql\"}}]")]
        public virtual void PutAuroraPostgresql(aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAwsIotAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}}]")]
        public virtual void PutAwsIotAnalytics(aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabricks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricks\"}}]")]
        public virtual void PutDatabricks(aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJira", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJira\"}}]")]
        public virtual void PutJira(aws.QuicksightDataSource.IQuicksightDataSourceParametersJira @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersJira)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMariaDb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDb\"}}]")]
        public virtual void PutMariaDb(aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMysql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysql\"}}]")]
        public virtual void PutMysql(aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOracle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracle\"}}]")]
        public virtual void PutOracle(aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostgresql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresql\"}}]")]
        public virtual void PutPostgresql(aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPresto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPresto\"}}]")]
        public virtual void PutPresto(aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRds\"}}]")]
        public virtual void PutRds(aws.QuicksightDataSource.IQuicksightDataSourceParametersRds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersRds)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshift", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshift\"}}]")]
        public virtual void PutRedshift(aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}}]")]
        public virtual void PutS3(aws.QuicksightDataSource.IQuicksightDataSourceParametersS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceNow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow\"}}]")]
        public virtual void PutServiceNow(aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnowflake", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflake\"}}]")]
        public virtual void PutSnowflake(aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpark", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSpark\"}}]")]
        public virtual void PutSpark(aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqlServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServer\"}}]")]
        public virtual void PutSqlServer(aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTeradata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradata\"}}]")]
        public virtual void PutTeradata(aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitter\"}}]")]
        public virtual void PutTwitter(aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmazonElasticsearch")]
        public virtual void ResetAmazonElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAthena")]
        public virtual void ResetAthena()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAurora")]
        public virtual void ResetAurora()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuroraPostgresql")]
        public virtual void ResetAuroraPostgresql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsIotAnalytics")]
        public virtual void ResetAwsIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabricks")]
        public virtual void ResetDatabricks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJira")]
        public virtual void ResetJira()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMariaDb")]
        public virtual void ResetMariaDb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysql")]
        public virtual void ResetMysql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracle")]
        public virtual void ResetOracle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresql")]
        public virtual void ResetPostgresql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPresto")]
        public virtual void ResetPresto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRds")]
        public virtual void ResetRds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshift")]
        public virtual void ResetRedshift()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceNow")]
        public virtual void ResetServiceNow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnowflake")]
        public virtual void ResetSnowflake()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpark")]
        public virtual void ResetSpark()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlServer")]
        public virtual void ResetSqlServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTeradata")]
        public virtual void ResetTeradata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitter")]
        public virtual void ResetTwitter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearchOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearchOutputReference AmazonElasticsearch
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearchOutputReference>()!;
        }

        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthenaOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersAthenaOutputReference Athena
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersAthenaOutputReference>()!;
        }

        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersAuroraOutputReference Aurora
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersAuroraOutputReference>()!;
        }

        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresqlOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersAuroraPostgresqlOutputReference AuroraPostgresql
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersAuroraPostgresqlOutputReference>()!;
        }

        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference AwsIotAnalytics
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "databricks", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricksOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersDatabricksOutputReference Databricks
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersDatabricksOutputReference>()!;
        }

        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJiraOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersJiraOutputReference Jira
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersJiraOutputReference>()!;
        }

        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDbOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersMariaDbOutputReference MariaDb
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersMariaDbOutputReference>()!;
        }

        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysqlOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersMysqlOutputReference Mysql
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersMysqlOutputReference>()!;
        }

        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracleOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersOracleOutputReference Oracle
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersOracleOutputReference>()!;
        }

        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresqlOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersPostgresqlOutputReference Postgresql
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersPostgresqlOutputReference>()!;
        }

        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPrestoOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersPrestoOutputReference Presto
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersPrestoOutputReference>()!;
        }

        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRdsOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersRdsOutputReference Rds
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersRdsOutputReference>()!;
        }

        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshiftOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersRedshiftOutputReference Redshift
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersRedshiftOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3OutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersS3OutputReference S3
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersS3OutputReference>()!;
        }

        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNowOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersServiceNowOutputReference ServiceNow
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersServiceNowOutputReference>()!;
        }

        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflakeOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersSnowflakeOutputReference Snowflake
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersSnowflakeOutputReference>()!;
        }

        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSparkOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersSparkOutputReference Spark
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersSparkOutputReference>()!;
        }

        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServerOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersSqlServerOutputReference SqlServer
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersSqlServerOutputReference>()!;
        }

        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradataOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersTeradataOutputReference Teradata
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersTeradataOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitterOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonElasticsearchInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearchInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "athenaInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena? AthenaInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auroraInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora? AuroraInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auroraPostgresqlInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresqlInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsIotAnalyticsInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalyticsInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databricksInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricks\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks? DatabricksInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jiraInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJira\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersJira? JiraInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersJira?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mariaDbInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb? MariaDbInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql? MysqlInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle? OracleInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresqlInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql? PostgresqlInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prestoInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto? PrestoInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdsInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRds\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersRds? RdsInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersRds?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift? RedshiftInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersS3? S3Input
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNowInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow? ServiceNowInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snowflakeInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake? SnowflakeInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark? SparkInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlServerInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer? SqlServerInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "teradataInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata? TeradataInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter? TwitterInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParameters\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParameters? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
