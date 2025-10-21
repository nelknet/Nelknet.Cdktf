namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicequotasTemplateAssociationState = { assignments: ResizeArray<aws.ServicequotasTemplateAssociation.ServicequotasTemplateAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template_association">aws_servicequotas_template_association</a>.
    /// </summary>
    type ServicequotasTemplateAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicequotasTemplateAssociationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : ServicequotasTemplateAssociationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template_association#skip_destroy-1">ServicequotasTemplateAssociation#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ServicequotasTemplateAssociationState, value: bool) : ServicequotasTemplateAssociationState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ServicequotasTemplateAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template_association#skip_destroy-1">ServicequotasTemplateAssociation#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ServicequotasTemplateAssociationState, value: HashiCorp.Cdktf.IResolvable) : ServicequotasTemplateAssociationState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ServicequotasTemplateAssociationState

        member _.Run(state: ServicequotasTemplateAssociationState) : aws.ServicequotasTemplateAssociation.ServicequotasTemplateAssociation =
            let config = aws.ServicequotasTemplateAssociation.ServicequotasTemplateAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicequotasTemplateAssociation.ServicequotasTemplateAssociation(StackContext.get (), logicalId, config)
