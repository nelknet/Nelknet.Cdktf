namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudformationStackSetInstanceState<'StackSetName> = { assignments: ResizeArray<aws.CloudformationStackSetInstance.CloudformationStackSetInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance">aws_cloudformation_stack_set_instance</a>.
    /// </summary>
    type CloudformationStackSetInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudformationStackSetInstanceState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackSetInstanceState<Missing>)

        member _.Zero(()) : CloudformationStackSetInstanceState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackSetInstanceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#stack_set_name-1">CloudformationStackSetInstance#stack_set_name</a>.
        /// </summary>
        [<CustomOperation "stack_set_name">]
        member _.StackSetName(state: CloudformationStackSetInstanceState<Missing>, value: string) : CloudformationStackSetInstanceState<Present> =
            state.assignments.Add(fun config -> config.StackSetName <- value)
            ({ assignments = state.assignments } : CloudformationStackSetInstanceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#account_id-1">CloudformationStackSetInstance#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: CloudformationStackSetInstanceState<'StackSetName>, value: string) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#call_as-1">CloudformationStackSetInstance#call_as</a>.
        /// </summary>
        [<CustomOperation "call_as">]
        member _.CallAs(state: CloudformationStackSetInstanceState<'StackSetName>, value: string) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.CallAs <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// deployment_targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#deployment_targets-1">CloudformationStackSetInstance#deployment_targets</a>
        /// </summary>
        [<CustomOperation "deployment_targets">]
        member _.DeploymentTargets(state: CloudformationStackSetInstanceState<'StackSetName>, value: aws.CloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargets) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.DeploymentTargets <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#id-1">CloudformationStackSetInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudformationStackSetInstanceState<'StackSetName>, value: string) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// operation_preferences block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#operation_preferences-1">CloudformationStackSetInstance#operation_preferences</a>
        /// </summary>
        [<CustomOperation "operation_preferences">]
        member _.OperationPreferences(state: CloudformationStackSetInstanceState<'StackSetName>, value: aws.CloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferences) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.OperationPreferences <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#parameter_overrides-1">CloudformationStackSetInstance#parameter_overrides</a>.
        /// </summary>
        [<CustomOperation "parameter_overrides">]
        member _.ParameterOverrides(state: CloudformationStackSetInstanceState<'StackSetName>, value: seq<string * string>) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.ParameterOverrides <- dict value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#region-1">CloudformationStackSetInstance#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: CloudformationStackSetInstanceState<'StackSetName>, value: string) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.Region <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#retain_stack-1">CloudformationStackSetInstance#retain_stack</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_stack">]
        member _.RetainStack(state: CloudformationStackSetInstanceState<'StackSetName>, value: bool) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.RetainStack <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#retain_stack-1">CloudformationStackSetInstance#retain_stack</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_stack">]
        member _.RetainStack(state: CloudformationStackSetInstanceState<'StackSetName>, value: HashiCorp.Cdktf.IResolvable) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.RetainStack <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#timeouts-1">CloudformationStackSetInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudformationStackSetInstanceState<'StackSetName>, value: aws.CloudformationStackSetInstance.CloudformationStackSetInstanceTimeouts) : CloudformationStackSetInstanceState<'StackSetName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudformationStackSetInstanceState<'StackSetName>

        member _.Run(state: CloudformationStackSetInstanceState<Present>) : aws.CloudformationStackSetInstance.CloudformationStackSetInstance =
            let config = aws.CloudformationStackSetInstance.CloudformationStackSetInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.CloudformationStackSetInstance.CloudformationStackSetInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudformationStackSetInstance: missing required arguments. Must call: stack_set_name.", 9999, IsError = true)>]
        member _.Run(_: CloudformationStackSetInstanceState<_>) : aws.CloudformationStackSetInstance.CloudformationStackSetInstance =
            Unchecked.defaultof<aws.CloudformationStackSetInstance.CloudformationStackSetInstance>
