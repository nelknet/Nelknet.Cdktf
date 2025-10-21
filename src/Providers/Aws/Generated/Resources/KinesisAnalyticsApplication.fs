namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisAnalyticsApplicationState<'Name> = { assignments: ResizeArray<aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application">aws_kinesis_analytics_application</a>.
    /// </summary>
    type KinesisAnalyticsApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisAnalyticsApplicationState<Missing> =
            ({ assignments = ResizeArray() } : KinesisAnalyticsApplicationState<Missing>)

        member _.Zero(()) : KinesisAnalyticsApplicationState<Missing> =
            ({ assignments = ResizeArray() } : KinesisAnalyticsApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#name-1">KinesisAnalyticsApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KinesisAnalyticsApplicationState<Missing>, value: string) : KinesisAnalyticsApplicationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KinesisAnalyticsApplicationState<Present>)

        /// <summary>
        /// cloudwatch_logging_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#cloudwatch_logging_options-1">KinesisAnalyticsApplication#cloudwatch_logging_options</a>
        /// </summary>
        [<CustomOperation "cloudwatch_logging_options">]
        member _.CloudwatchLoggingOptions(state: KinesisAnalyticsApplicationState<'Name>, value: aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationCloudwatchLoggingOptions) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.CloudwatchLoggingOptions <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#code-1">KinesisAnalyticsApplication#code</a>.
        /// </summary>
        [<CustomOperation "code">]
        member _.Code(state: KinesisAnalyticsApplicationState<'Name>, value: string) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Code <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#description-1">KinesisAnalyticsApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KinesisAnalyticsApplicationState<'Name>, value: string) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#id-1">KinesisAnalyticsApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KinesisAnalyticsApplicationState<'Name>, value: string) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// inputs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#inputs-1">KinesisAnalyticsApplication#inputs</a>
        /// </summary>
        [<CustomOperation "inputs">]
        member _.Inputs(state: KinesisAnalyticsApplicationState<'Name>, value: aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationInputs) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Inputs <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// outputs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#outputs-1">KinesisAnalyticsApplication#outputs</a> Accepts: aws.IResolvable | aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputs[]
        /// </summary>
        [<CustomOperation "outputs">]
        member _.Outputs(state: KinesisAnalyticsApplicationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Outputs <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// reference_data_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#reference_data_sources-1">KinesisAnalyticsApplication#reference_data_sources</a>
        /// </summary>
        [<CustomOperation "reference_data_sources">]
        member _.ReferenceDataSources(state: KinesisAnalyticsApplicationState<'Name>, value: aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSources) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.ReferenceDataSources <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#start_application-1">KinesisAnalyticsApplication#start_application</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_application">]
        member _.StartApplication(state: KinesisAnalyticsApplicationState<'Name>, value: bool) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.StartApplication <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#start_application-1">KinesisAnalyticsApplication#start_application</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_application">]
        member _.StartApplication(state: KinesisAnalyticsApplicationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.StartApplication <- value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#tags-1">KinesisAnalyticsApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KinesisAnalyticsApplicationState<'Name>, value: seq<string * string>) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KinesisAnalyticsApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#tags_all-1">KinesisAnalyticsApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KinesisAnalyticsApplicationState<'Name>, value: seq<string * string>) : KinesisAnalyticsApplicationState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KinesisAnalyticsApplicationState<'Name>

        member _.Run(state: KinesisAnalyticsApplicationState<Present>) : aws.KinesisAnalyticsApplication.KinesisAnalyticsApplication =
            let config = aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisAnalyticsApplication.KinesisAnalyticsApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisAnalyticsApplication: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: KinesisAnalyticsApplicationState<_>) : aws.KinesisAnalyticsApplication.KinesisAnalyticsApplication =
            Unchecked.defaultof<aws.KinesisAnalyticsApplication.KinesisAnalyticsApplication>
