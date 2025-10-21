namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAuditmanagerControlState<'Name, 'Type> = { assignments: ResizeArray<aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control">aws_auditmanager_control</a>.
    /// </summary>
    type DataAwsAuditmanagerControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAuditmanagerControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAuditmanagerControlState<Missing, Missing>)

        member _.Zero(()) : DataAwsAuditmanagerControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAuditmanagerControlState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#name-1">DataAwsAuditmanagerControl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAuditmanagerControlState<Missing, 'Type>, value: string) : DataAwsAuditmanagerControlState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAuditmanagerControlState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#type-1">DataAwsAuditmanagerControl#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsAuditmanagerControlState<'Name, Missing>, value: string) : DataAwsAuditmanagerControlState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsAuditmanagerControlState<'Name, Present>)

        /// <summary>
        /// control_mapping_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#control_mapping_sources-1">DataAwsAuditmanagerControl#control_mapping_sources</a> Accepts: aws.IResolvable | aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSources[]
        /// </summary>
        [<CustomOperation "control_mapping_sources">]
        member _.ControlMappingSources(state: DataAwsAuditmanagerControlState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : DataAwsAuditmanagerControlState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.ControlMappingSources <- value)
            state : DataAwsAuditmanagerControlState<'Name, 'Type>

        member _.Run(state: DataAwsAuditmanagerControlState<Present, Present>) : aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControl =
            let config = aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControlConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAuditmanagerControl: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAuditmanagerControlState<_, _>) : aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControl =
            Unchecked.defaultof<aws.DataAwsAuditmanagerControl.DataAwsAuditmanagerControl>
