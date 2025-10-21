namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudformationStackInstancesState<'StackSetName> = { assignments: ResizeArray<aws.CloudformationStackInstances.CloudformationStackInstancesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances">aws_cloudformation_stack_instances</a>.
    /// </summary>
    type CloudformationStackInstancesBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudformationStackInstancesState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackInstancesState<Missing>)

        member _.Zero(()) : CloudformationStackInstancesState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackInstancesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#stack_set_name-1">CloudformationStackInstances#stack_set_name</a>.
        /// </summary>
        [<CustomOperation "stack_set_name">]
        member _.StackSetName(state: CloudformationStackInstancesState<Missing>, value: string) : CloudformationStackInstancesState<Present> =
            state.assignments.Add(fun config -> config.StackSetName <- value)
            ({ assignments = state.assignments } : CloudformationStackInstancesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#accounts-1">CloudformationStackInstances#accounts</a>.
        /// </summary>
        [<CustomOperation "accounts">]
        member _.Accounts(state: CloudformationStackInstancesState<'StackSetName>, value: seq<string>) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.Accounts <- (value |> Seq.toArray))
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#call_as-1">CloudformationStackInstances#call_as</a>.
        /// </summary>
        [<CustomOperation "call_as">]
        member _.CallAs(state: CloudformationStackInstancesState<'StackSetName>, value: string) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.CallAs <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// deployment_targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#deployment_targets-1">CloudformationStackInstances#deployment_targets</a>
        /// </summary>
        [<CustomOperation "deployment_targets">]
        member _.DeploymentTargets(state: CloudformationStackInstancesState<'StackSetName>, value: aws.CloudformationStackInstances.CloudformationStackInstancesDeploymentTargets) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.DeploymentTargets <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#id-1">CloudformationStackInstances#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudformationStackInstancesState<'StackSetName>, value: string) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// operation_preferences block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#operation_preferences-1">CloudformationStackInstances#operation_preferences</a>
        /// </summary>
        [<CustomOperation "operation_preferences">]
        member _.OperationPreferences(state: CloudformationStackInstancesState<'StackSetName>, value: aws.CloudformationStackInstances.CloudformationStackInstancesOperationPreferences) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.OperationPreferences <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#parameter_overrides-1">CloudformationStackInstances#parameter_overrides</a>.
        /// </summary>
        [<CustomOperation "parameter_overrides">]
        member _.ParameterOverrides(state: CloudformationStackInstancesState<'StackSetName>, value: seq<string * string>) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.ParameterOverrides <- dict value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#regions-1">CloudformationStackInstances#regions</a>.
        /// </summary>
        [<CustomOperation "regions">]
        member _.Regions(state: CloudformationStackInstancesState<'StackSetName>, value: seq<string>) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.Regions <- (value |> Seq.toArray))
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#retain_stacks-1">CloudformationStackInstances#retain_stacks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_stacks">]
        member _.RetainStacks(state: CloudformationStackInstancesState<'StackSetName>, value: bool) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.RetainStacks <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#retain_stacks-1">CloudformationStackInstances#retain_stacks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_stacks">]
        member _.RetainStacks(state: CloudformationStackInstancesState<'StackSetName>, value: HashiCorp.Cdktf.IResolvable) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.RetainStacks <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#timeouts-1">CloudformationStackInstances#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudformationStackInstancesState<'StackSetName>, value: aws.CloudformationStackInstances.CloudformationStackInstancesTimeouts) : CloudformationStackInstancesState<'StackSetName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudformationStackInstancesState<'StackSetName>

        member _.Run(state: CloudformationStackInstancesState<Present>) : aws.CloudformationStackInstances.CloudformationStackInstances =
            let config = aws.CloudformationStackInstances.CloudformationStackInstancesConfig()
            for setter in state.assignments do
                setter config
            aws.CloudformationStackInstances.CloudformationStackInstances(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudformationStackInstances: missing required arguments. Must call: stack_set_name.", 9999, IsError = true)>]
        member _.Run(_: CloudformationStackInstancesState<_>) : aws.CloudformationStackInstances.CloudformationStackInstances =
            Unchecked.defaultof<aws.CloudformationStackInstances.CloudformationStackInstances>
