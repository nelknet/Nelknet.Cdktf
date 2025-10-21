namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> = { assignments: ResizeArray<aws.QuicksightDashboard.QuicksightDashboardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard">aws_quicksight_dashboard</a>.
    /// </summary>
    type QuicksightDashboardBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightDashboardState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDashboardState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightDashboardState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDashboardState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#dashboard_id-1">QuicksightDashboard#dashboard_id</a>.
        /// </summary>
        [<CustomOperation "dashboard_id">]
        member _.DashboardId(state: QuicksightDashboardState<Missing, 'Name, 'VersionDescription>, value: string) : QuicksightDashboardState<Present, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.DashboardId <- value)
            ({ assignments = state.assignments } : QuicksightDashboardState<Present, 'Name, 'VersionDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#name-1">QuicksightDashboard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightDashboardState<'DashboardId, Missing, 'VersionDescription>, value: string) : QuicksightDashboardState<'DashboardId, Present, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightDashboardState<'DashboardId, Present, 'VersionDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#version_description-1">QuicksightDashboard#version_description</a>.
        /// </summary>
        [<CustomOperation "version_description">]
        member _.VersionDescription(state: QuicksightDashboardState<'DashboardId, 'Name, Missing>, value: string) : QuicksightDashboardState<'DashboardId, 'Name, Present> =
            state.assignments.Add(fun config -> config.VersionDescription <- value)
            ({ assignments = state.assignments } : QuicksightDashboardState<'DashboardId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#aws_account_id-1">QuicksightDashboard#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: string) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// dashboard_publish_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#dashboard_publish_options-1">QuicksightDashboard#dashboard_publish_options</a>
        /// </summary>
        [<CustomOperation "dashboard_publish_options">]
        member _.DashboardPublishOptions(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptions) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.DashboardPublishOptions <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#definition-1">QuicksightDashboard#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: obj) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#id-1">QuicksightDashboard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: string) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#parameters-1">QuicksightDashboard#parameters</a>
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: aws.QuicksightDashboard.QuicksightDashboardParameters) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#permissions-1">QuicksightDashboard#permissions</a> Accepts: aws.IResolvable | aws.QuicksightDashboard.QuicksightDashboardPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// source_entity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#source_entity-1">QuicksightDashboard#source_entity</a>
        /// </summary>
        [<CustomOperation "source_entity">]
        member _.SourceEntity(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: aws.QuicksightDashboard.QuicksightDashboardSourceEntity) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.SourceEntity <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#tags-1">QuicksightDashboard#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: seq<string * string>) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#tags_all-1">QuicksightDashboard#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: seq<string * string>) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#theme_arn-1">QuicksightDashboard#theme_arn</a>.
        /// </summary>
        [<CustomOperation "theme_arn">]
        member _.ThemeArn(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: string) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.ThemeArn <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#timeouts-1">QuicksightDashboard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>, value: aws.QuicksightDashboard.QuicksightDashboardTimeouts) : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightDashboardState<'DashboardId, 'Name, 'VersionDescription>

        member _.Run(state: QuicksightDashboardState<Present, Present, Present>) : aws.QuicksightDashboard.QuicksightDashboard =
            let config = aws.QuicksightDashboard.QuicksightDashboardConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightDashboard.QuicksightDashboard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightDashboard: missing required arguments. Must call: dashboard_id, name, version_description.", 9999, IsError = true)>]
        member _.Run(_: QuicksightDashboardState<_, _, _>) : aws.QuicksightDashboard.QuicksightDashboard =
            Unchecked.defaultof<aws.QuicksightDashboard.QuicksightDashboard>
