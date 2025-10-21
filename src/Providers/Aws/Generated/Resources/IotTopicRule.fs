namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> = { assignments: ResizeArray<aws.IotTopicRule.IotTopicRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule">aws_iot_topic_rule</a>.
    /// </summary>
    type IotTopicRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotTopicRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotTopicRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IotTopicRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotTopicRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#enabled-1">IotTopicRule#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotTopicRuleState<Missing, 'Name, 'Sql, 'SqlVersion>, value: bool) : IotTopicRuleState<Present, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IotTopicRuleState<Present, 'Name, 'Sql, 'SqlVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#enabled-1">IotTopicRule#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotTopicRuleState<Missing, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<Present, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IotTopicRuleState<Present, 'Name, 'Sql, 'SqlVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#name-1">IotTopicRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotTopicRuleState<'Enabled, Missing, 'Sql, 'SqlVersion>, value: string) : IotTopicRuleState<'Enabled, Present, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotTopicRuleState<'Enabled, Present, 'Sql, 'SqlVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sql-1">IotTopicRule#sql</a>.
        /// </summary>
        [<CustomOperation "sql">]
        member _.Sql(state: IotTopicRuleState<'Enabled, 'Name, Missing, 'SqlVersion>, value: string) : IotTopicRuleState<'Enabled, 'Name, Present, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Sql <- value)
            ({ assignments = state.assignments } : IotTopicRuleState<'Enabled, 'Name, Present, 'SqlVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sql_version-1">IotTopicRule#sql_version</a>.
        /// </summary>
        [<CustomOperation "sql_version">]
        member _.SqlVersion(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, Missing>, value: string) : IotTopicRuleState<'Enabled, 'Name, 'Sql, Present> =
            state.assignments.Add(fun config -> config.SqlVersion <- value)
            ({ assignments = state.assignments } : IotTopicRuleState<'Enabled, 'Name, 'Sql, Present>)

        /// <summary>
        /// cloudwatch_alarm block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_alarm-1">IotTopicRule#cloudwatch_alarm</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleCloudwatchAlarm[]
        /// </summary>
        [<CustomOperation "cloudwatch_alarm">]
        member _.CloudwatchAlarm(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.CloudwatchAlarm <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// cloudwatch_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_logs-1">IotTopicRule#cloudwatch_logs</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleCloudwatchLogs[]
        /// </summary>
        [<CustomOperation "cloudwatch_logs">]
        member _.CloudwatchLogs(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.CloudwatchLogs <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// cloudwatch_metric block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#cloudwatch_metric-1">IotTopicRule#cloudwatch_metric</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleCloudwatchMetric[]
        /// </summary>
        [<CustomOperation "cloudwatch_metric">]
        member _.CloudwatchMetric(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.CloudwatchMetric <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#description-1">IotTopicRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: string) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// dynamodb block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodb-1">IotTopicRule#dynamodb</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleDynamodb[]
        /// </summary>
        [<CustomOperation "dynamodb">]
        member _.Dynamodb(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Dynamodb <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// dynamodbv2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#dynamodbv2-1">IotTopicRule#dynamodbv2</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleDynamodbv2[]
        /// </summary>
        [<CustomOperation "dynamodbv2">]
        member _.Dynamodbv2(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Dynamodbv2 <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// elasticsearch block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#elasticsearch-1">IotTopicRule#elasticsearch</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleElasticsearch[]
        /// </summary>
        [<CustomOperation "elasticsearch">]
        member _.Elasticsearch(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Elasticsearch <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// error_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#error_action-1">IotTopicRule#error_action</a>
        /// </summary>
        [<CustomOperation "error_action">]
        member _.ErrorAction(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: aws.IotTopicRule.IotTopicRuleErrorAction) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.ErrorAction <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// firehose block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#firehose-1">IotTopicRule#firehose</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleFirehose[]
        /// </summary>
        [<CustomOperation "firehose">]
        member _.Firehose(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Firehose <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// http block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#http-1">IotTopicRule#http</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleHttp[]
        /// </summary>
        [<CustomOperation "http">]
        member _.Http(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Http <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#id-1">IotTopicRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: string) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// iot_analytics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_analytics-1">IotTopicRule#iot_analytics</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleIotAnalytics[]
        /// </summary>
        [<CustomOperation "iot_analytics">]
        member _.IotAnalytics(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.IotAnalytics <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// iot_events block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#iot_events-1">IotTopicRule#iot_events</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleIotEvents[]
        /// </summary>
        [<CustomOperation "iot_events">]
        member _.IotEvents(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.IotEvents <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// kafka block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kafka-1">IotTopicRule#kafka</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleKafka[]
        /// </summary>
        [<CustomOperation "kafka">]
        member _.Kafka(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Kafka <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// kinesis block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#kinesis-1">IotTopicRule#kinesis</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleKinesis[]
        /// </summary>
        [<CustomOperation "kinesis">]
        member _.Kinesis(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Kinesis <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// lambda block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#lambda-1">IotTopicRule#lambda</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleLambda[]
        /// </summary>
        [<CustomOperation "lambda">]
        member _.Lambda(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Lambda <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// republish block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#republish-1">IotTopicRule#republish</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleRepublish[]
        /// </summary>
        [<CustomOperation "republish">]
        member _.Republish(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Republish <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// s3 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#s3-1">IotTopicRule#s3</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleS3[]
        /// </summary>
        [<CustomOperation "s3">]
        member _.S3(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.S3 <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// sns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sns-1">IotTopicRule#sns</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleSns[]
        /// </summary>
        [<CustomOperation "sns">]
        member _.Sns(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Sns <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// sqs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#sqs-1">IotTopicRule#sqs</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleSqs[]
        /// </summary>
        [<CustomOperation "sqs">]
        member _.Sqs(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Sqs <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// step_functions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#step_functions-1">IotTopicRule#step_functions</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleStepFunctions[]
        /// </summary>
        [<CustomOperation "step_functions">]
        member _.StepFunctions(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.StepFunctions <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#tags-1">IotTopicRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: seq<string * string>) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#tags_all-1">IotTopicRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: seq<string * string>) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        /// <summary>
        /// timestream block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#timestream-1">IotTopicRule#timestream</a> Accepts: aws.IResolvable | aws.IotTopicRule.IotTopicRuleTimestream[]
        /// </summary>
        [<CustomOperation "timestream">]
        member _.Timestream(state: IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion> =
            state.assignments.Add(fun config -> config.Timestream <- value)
            state : IotTopicRuleState<'Enabled, 'Name, 'Sql, 'SqlVersion>

        member _.Run(state: IotTopicRuleState<Present, Present, Present, Present>) : aws.IotTopicRule.IotTopicRule =
            let config = aws.IotTopicRule.IotTopicRuleConfig()
            for setter in state.assignments do
                setter config
            aws.IotTopicRule.IotTopicRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotTopicRule: missing required arguments. Must call: enabled, name, sql, sql_version.", 9999, IsError = true)>]
        member _.Run(_: IotTopicRuleState<_, _, _, _>) : aws.IotTopicRule.IotTopicRule =
            Unchecked.defaultof<aws.IotTopicRule.IotTopicRule>
