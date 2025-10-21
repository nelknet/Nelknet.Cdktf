namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationinsightsApplicationState<'ResourceGroupName> = { assignments: ResizeArray<aws.ApplicationinsightsApplication.ApplicationinsightsApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application">aws_applicationinsights_application</a>.
    /// </summary>
    type ApplicationinsightsApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationinsightsApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ApplicationinsightsApplicationState<Missing>)

        member _.Zero(()) : ApplicationinsightsApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ApplicationinsightsApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#resource_group_name-1">ApplicationinsightsApplication#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationinsightsApplicationState<Missing>, value: string) : ApplicationinsightsApplicationState<Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationinsightsApplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#auto_config_enabled-1">ApplicationinsightsApplication#auto_config_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_config_enabled">]
        member _.AutoConfigEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: bool) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoConfigEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#auto_config_enabled-1">ApplicationinsightsApplication#auto_config_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_config_enabled">]
        member _.AutoConfigEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoConfigEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#auto_create-1">ApplicationinsightsApplication#auto_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_create">]
        member _.AutoCreate(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: bool) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoCreate <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#auto_create-1">ApplicationinsightsApplication#auto_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_create">]
        member _.AutoCreate(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoCreate <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#cwe_monitor_enabled-1">ApplicationinsightsApplication#cwe_monitor_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cwe_monitor_enabled">]
        member _.CweMonitorEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: bool) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CweMonitorEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#cwe_monitor_enabled-1">ApplicationinsightsApplication#cwe_monitor_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cwe_monitor_enabled">]
        member _.CweMonitorEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CweMonitorEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#grouping_type-1">ApplicationinsightsApplication#grouping_type</a>.
        /// </summary>
        [<CustomOperation "grouping_type">]
        member _.GroupingType(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: string) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GroupingType <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#id-1">ApplicationinsightsApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: string) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#ops_center_enabled-1">ApplicationinsightsApplication#ops_center_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ops_center_enabled">]
        member _.OpsCenterEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: bool) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpsCenterEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#ops_center_enabled-1">ApplicationinsightsApplication#ops_center_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ops_center_enabled">]
        member _.OpsCenterEnabled(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpsCenterEnabled <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#ops_item_sns_topic_arn-1">ApplicationinsightsApplication#ops_item_sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "ops_item_sns_topic_arn">]
        member _.OpsItemSnsTopicArn(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: string) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OpsItemSnsTopicArn <- value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#tags-1">ApplicationinsightsApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: seq<string * string>) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/applicationinsights_application#tags_all-1">ApplicationinsightsApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApplicationinsightsApplicationState<'ResourceGroupName>, value: seq<string * string>) : ApplicationinsightsApplicationState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApplicationinsightsApplicationState<'ResourceGroupName>

        member _.Run(state: ApplicationinsightsApplicationState<Present>) : aws.ApplicationinsightsApplication.ApplicationinsightsApplication =
            let config = aws.ApplicationinsightsApplication.ApplicationinsightsApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.ApplicationinsightsApplication.ApplicationinsightsApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.applicationinsightsApplication: missing required arguments. Must call: resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationinsightsApplicationState<_>) : aws.ApplicationinsightsApplication.ApplicationinsightsApplication =
            Unchecked.defaultof<aws.ApplicationinsightsApplication.ApplicationinsightsApplication>
