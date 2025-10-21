namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubAccountState = { assignments: ResizeArray<aws.SecurityhubAccount.SecurityhubAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account">aws_securityhub_account</a>.
    /// </summary>
    type SecurityhubAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SecurityhubAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#auto_enable_controls-1">SecurityhubAccount#auto_enable_controls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable_controls">]
        member _.AutoEnableControls(state: SecurityhubAccountState, value: bool) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.AutoEnableControls <- value)
            state : SecurityhubAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#auto_enable_controls-1">SecurityhubAccount#auto_enable_controls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable_controls">]
        member _.AutoEnableControls(state: SecurityhubAccountState, value: HashiCorp.Cdktf.IResolvable) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.AutoEnableControls <- value)
            state : SecurityhubAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#control_finding_generator-1">SecurityhubAccount#control_finding_generator</a>.
        /// </summary>
        [<CustomOperation "control_finding_generator">]
        member _.ControlFindingGenerator(state: SecurityhubAccountState, value: string) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.ControlFindingGenerator <- value)
            state : SecurityhubAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#enable_default_standards-1">SecurityhubAccount#enable_default_standards</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_standards">]
        member _.EnableDefaultStandards(state: SecurityhubAccountState, value: bool) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.EnableDefaultStandards <- value)
            state : SecurityhubAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#enable_default_standards-1">SecurityhubAccount#enable_default_standards</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_standards">]
        member _.EnableDefaultStandards(state: SecurityhubAccountState, value: HashiCorp.Cdktf.IResolvable) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.EnableDefaultStandards <- value)
            state : SecurityhubAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_account#id-1">SecurityhubAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubAccountState, value: string) : SecurityhubAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubAccountState

        member _.Run(state: SecurityhubAccountState) : aws.SecurityhubAccount.SecurityhubAccount =
            let config = aws.SecurityhubAccount.SecurityhubAccountConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubAccount.SecurityhubAccount(StackContext.get (), logicalId, config)
