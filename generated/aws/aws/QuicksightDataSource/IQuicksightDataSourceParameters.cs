using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParameters), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParameters")]
    public interface IQuicksightDataSourceParameters
    {
        /// <summary>amazon_elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
        /// </remarks>
        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>athena block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#athena QuicksightDataSource#athena}
        /// </remarks>
        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena? Athena
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora QuicksightDataSource#aurora}
        /// </remarks>
        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora? Aurora
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora_postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
        /// </remarks>
        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
        /// </remarks>
        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>databricks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#databricks QuicksightDataSource#databricks}
        /// </remarks>
        [JsiiProperty(name: "databricks", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks? Databricks
        {
            get
            {
                return null;
            }
        }

        /// <summary>jira block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#jira QuicksightDataSource#jira}
        /// </remarks>
        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJira\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersJira? Jira
        {
            get
            {
                return null;
            }
        }

        /// <summary>maria_db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
        /// </remarks>
        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb? MariaDb
        {
            get
            {
                return null;
            }
        }

        /// <summary>mysql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#mysql QuicksightDataSource#mysql}
        /// </remarks>
        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql? Mysql
        {
            get
            {
                return null;
            }
        }

        /// <summary>oracle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#oracle QuicksightDataSource#oracle}
        /// </remarks>
        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle? Oracle
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
        /// </remarks>
        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql? Postgresql
        {
            get
            {
                return null;
            }
        }

        /// <summary>presto block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#presto QuicksightDataSource#presto}
        /// </remarks>
        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto? Presto
        {
            get
            {
                return null;
            }
        }

        /// <summary>rds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#rds QuicksightDataSource#rds}
        /// </remarks>
        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersRds? Rds
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#redshift QuicksightDataSource#redshift}
        /// </remarks>
        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift? Redshift
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#s3 QuicksightDataSource#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersS3? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#service_now QuicksightDataSource#service_now}
        /// </remarks>
        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow? ServiceNow
        {
            get
            {
                return null;
            }
        }

        /// <summary>snowflake block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
        /// </remarks>
        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake? Snowflake
        {
            get
            {
                return null;
            }
        }

        /// <summary>spark block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#spark QuicksightDataSource#spark}
        /// </remarks>
        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark? Spark
        {
            get
            {
                return null;
            }
        }

        /// <summary>sql_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
        /// </remarks>
        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer? SqlServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>teradata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#teradata QuicksightDataSource#teradata}
        /// </remarks>
        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata? Teradata
        {
            get
            {
                return null;
            }
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#twitter QuicksightDataSource#twitter}
        /// </remarks>
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter? Twitter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParameters), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParameters")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amazon_elasticsearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch?>();
            }

            /// <summary>athena block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#athena QuicksightDataSource#athena}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena? Athena
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena?>();
            }

            /// <summary>aurora block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora QuicksightDataSource#aurora}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora? Aurora
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora?>();
            }

            /// <summary>aurora_postgresql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql?>();
            }

            /// <summary>aws_iot_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics?>();
            }

            /// <summary>databricks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#databricks QuicksightDataSource#databricks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databricks", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricks\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks? Databricks
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks?>();
            }

            /// <summary>jira block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#jira QuicksightDataSource#jira}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJira\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersJira? Jira
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersJira?>();
            }

            /// <summary>maria_db block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb? MariaDb
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb?>();
            }

            /// <summary>mysql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#mysql QuicksightDataSource#mysql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql? Mysql
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql?>();
            }

            /// <summary>oracle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#oracle QuicksightDataSource#oracle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle? Oracle
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle?>();
            }

            /// <summary>postgresql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql? Postgresql
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql?>();
            }

            /// <summary>presto block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#presto QuicksightDataSource#presto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto? Presto
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto?>();
            }

            /// <summary>rds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#rds QuicksightDataSource#rds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRds\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersRds? Rds
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersRds?>();
            }

            /// <summary>redshift block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#redshift QuicksightDataSource#redshift}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift? Redshift
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#s3 QuicksightDataSource#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersS3? S3
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersS3?>();
            }

            /// <summary>service_now block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#service_now QuicksightDataSource#service_now}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow? ServiceNow
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow?>();
            }

            /// <summary>snowflake block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake? Snowflake
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake?>();
            }

            /// <summary>spark block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#spark QuicksightDataSource#spark}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark? Spark
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark?>();
            }

            /// <summary>sql_server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer? SqlServer
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer?>();
            }

            /// <summary>teradata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#teradata QuicksightDataSource#teradata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata? Teradata
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata?>();
            }

            /// <summary>twitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#twitter QuicksightDataSource#twitter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter? Twitter
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter?>();
            }
        }
    }
}
