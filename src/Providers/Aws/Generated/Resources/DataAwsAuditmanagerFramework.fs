namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAuditmanagerFrameworkState<'FrameworkType, 'Name> = { assignments: ResizeArray<aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework">aws_auditmanager_framework</a>.
    /// </summary>
    type DataAwsAuditmanagerFrameworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAuditmanagerFrameworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAuditmanagerFrameworkState<Missing, Missing>)

        member _.Zero(()) : DataAwsAuditmanagerFrameworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAuditmanagerFrameworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#framework_type-1">DataAwsAuditmanagerFramework#framework_type</a>.
        /// </summary>
        [<CustomOperation "framework_type">]
        member _.FrameworkType(state: DataAwsAuditmanagerFrameworkState<Missing, 'Name>, value: string) : DataAwsAuditmanagerFrameworkState<Present, 'Name> =
            state.assignments.Add(fun config -> config.FrameworkType <- value)
            ({ assignments = state.assignments } : DataAwsAuditmanagerFrameworkState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#name-1">DataAwsAuditmanagerFramework#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAuditmanagerFrameworkState<'FrameworkType, Missing>, value: string) : DataAwsAuditmanagerFrameworkState<'FrameworkType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAuditmanagerFrameworkState<'FrameworkType, Present>)

        /// <summary>
        /// control_sets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#control_sets-1">DataAwsAuditmanagerFramework#control_sets</a> Accepts: aws.IResolvable | aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSets[]
        /// </summary>
        [<CustomOperation "control_sets">]
        member _.ControlSets(state: DataAwsAuditmanagerFrameworkState<'FrameworkType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataAwsAuditmanagerFrameworkState<'FrameworkType, 'Name> =
            state.assignments.Add(fun config -> config.ControlSets <- value)
            state : DataAwsAuditmanagerFrameworkState<'FrameworkType, 'Name>

        member _.Run(state: DataAwsAuditmanagerFrameworkState<Present, Present>) : aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFramework =
            let config = aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFramework(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAuditmanagerFramework: missing required arguments. Must call: framework_type, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAuditmanagerFrameworkState<_, _>) : aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFramework =
            Unchecked.defaultof<aws.DataAwsAuditmanagerFramework.DataAwsAuditmanagerFramework>
