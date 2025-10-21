namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn> = { assignments: ResizeArray<aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration">aws_wafv2_web_acl_logging_configuration</a>.
    /// </summary>
    type Wafv2WebAclLoggingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2WebAclLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclLoggingConfigurationState<Missing, Missing>)

        member _.Zero(()) : Wafv2WebAclLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclLoggingConfigurationState<Missing, Missing>)

        /// <summary>
        /// AWS Kinesis Firehose Delivery Stream ARNs. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#log_destination_configs-1">Wafv2WebAclLoggingConfiguration#log_destination_configs</a>
        /// </summary>
        [<CustomOperation "log_destination_configs">]
        member _.LogDestinationConfigs(state: Wafv2WebAclLoggingConfigurationState<Missing, 'ResourceArn>, value: seq<string>) : Wafv2WebAclLoggingConfigurationState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.LogDestinationConfigs <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Wafv2WebAclLoggingConfigurationState<Present, 'ResourceArn>)

        /// <summary>
        /// AWS WebACL ARN. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#resource_arn-1">Wafv2WebAclLoggingConfiguration#resource_arn</a>
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, Missing>, value: string) : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#id-1">Wafv2WebAclLoggingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>, value: string) : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>

        /// <summary>
        /// logging_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#logging_filter-1">Wafv2WebAclLoggingConfiguration#logging_filter</a>
        /// </summary>
        [<CustomOperation "logging_filter">]
        member _.LoggingFilter(state: Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>, value: aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationLoggingFilter) : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn> =
            state.assignments.Add(fun config -> config.LoggingFilter <- value)
            state : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>

        /// <summary>
        /// redacted_fields block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#redacted_fields-1">Wafv2WebAclLoggingConfiguration#redacted_fields</a> Accepts: aws.IResolvable | aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationRedactedFields[]
        /// </summary>
        [<CustomOperation "redacted_fields">]
        member _.RedactedFields(state: Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>, value: HashiCorp.Cdktf.IResolvable) : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn> =
            state.assignments.Add(fun config -> config.RedactedFields <- value)
            state : Wafv2WebAclLoggingConfigurationState<'LogDestinationConfigs, 'ResourceArn>

        member _.Run(state: Wafv2WebAclLoggingConfigurationState<Present, Present>) : aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfiguration =
            let config = aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2WebAclLoggingConfiguration: missing required arguments. Must call: log_destination_configs, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: Wafv2WebAclLoggingConfigurationState<_, _>) : aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfiguration =
            Unchecked.defaultof<aws.Wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfiguration>
