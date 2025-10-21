namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerFrameworkState<'Name> = { assignments: ResizeArray<aws.AuditmanagerFramework.AuditmanagerFrameworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework">aws_auditmanager_framework</a>.
    /// </summary>
    type AuditmanagerFrameworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerFrameworkState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerFrameworkState<Missing>)

        member _.Zero(()) : AuditmanagerFrameworkState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerFrameworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#name-1">AuditmanagerFramework#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AuditmanagerFrameworkState<Missing>, value: string) : AuditmanagerFrameworkState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AuditmanagerFrameworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#compliance_type-1">AuditmanagerFramework#compliance_type</a>.
        /// </summary>
        [<CustomOperation "compliance_type">]
        member _.ComplianceType(state: AuditmanagerFrameworkState<'Name>, value: string) : AuditmanagerFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.ComplianceType <- value)
            state : AuditmanagerFrameworkState<'Name>

        /// <summary>
        /// control_sets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#control_sets-1">AuditmanagerFramework#control_sets</a> Accepts: aws.IResolvable | aws.AuditmanagerFramework.AuditmanagerFrameworkControlSets[]
        /// </summary>
        [<CustomOperation "control_sets">]
        member _.ControlSets(state: AuditmanagerFrameworkState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.ControlSets <- value)
            state : AuditmanagerFrameworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#description-1">AuditmanagerFramework#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AuditmanagerFrameworkState<'Name>, value: string) : AuditmanagerFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AuditmanagerFrameworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#tags-1">AuditmanagerFramework#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AuditmanagerFrameworkState<'Name>, value: seq<string * string>) : AuditmanagerFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AuditmanagerFrameworkState<'Name>

        member _.Run(state: AuditmanagerFrameworkState<Present>) : aws.AuditmanagerFramework.AuditmanagerFramework =
            let config = aws.AuditmanagerFramework.AuditmanagerFrameworkConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerFramework.AuditmanagerFramework(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerFramework: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerFrameworkState<_>) : aws.AuditmanagerFramework.AuditmanagerFramework =
            Unchecked.defaultof<aws.AuditmanagerFramework.AuditmanagerFramework>
