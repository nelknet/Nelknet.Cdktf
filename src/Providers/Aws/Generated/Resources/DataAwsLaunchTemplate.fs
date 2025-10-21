namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLaunchTemplateState = { assignments: ResizeArray<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template">aws_launch_template</a>.
    /// </summary>
    type DataAwsLaunchTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLaunchTemplateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLaunchTemplateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#filter-1">DataAwsLaunchTemplate#filter</a> Accepts: aws.IResolvable | aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsLaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : DataAwsLaunchTemplateState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsLaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#id-1">DataAwsLaunchTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLaunchTemplateState, value: string) : DataAwsLaunchTemplateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#name-1">DataAwsLaunchTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLaunchTemplateState, value: string) : DataAwsLaunchTemplateState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsLaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#tags-1">DataAwsLaunchTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLaunchTemplateState, value: seq<string * string>) : DataAwsLaunchTemplateState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLaunchTemplateState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#timeouts-1">DataAwsLaunchTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsLaunchTemplateState, value: aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts) : DataAwsLaunchTemplateState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsLaunchTemplateState

        member _.Run(state: DataAwsLaunchTemplateState) : aws.DataAwsLaunchTemplate.DataAwsLaunchTemplate =
            let config = aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLaunchTemplate.DataAwsLaunchTemplate(StackContext.get (), logicalId, config)
