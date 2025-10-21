namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicequotasTemplateState<'QuotaCode, 'Region, 'ServiceCode, 'Value> = { assignments: ResizeArray<aws.ServicequotasTemplate.ServicequotasTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template">aws_servicequotas_template</a>.
    /// </summary>
    type ServicequotasTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicequotasTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicequotasTemplateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServicequotasTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicequotasTemplateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template#quota_code-1">ServicequotasTemplate#quota_code</a>.
        /// </summary>
        [<CustomOperation "quota_code">]
        member _.QuotaCode(state: ServicequotasTemplateState<Missing, 'Region, 'ServiceCode, 'Value>, value: string) : ServicequotasTemplateState<Present, 'Region, 'ServiceCode, 'Value> =
            state.assignments.Add(fun config -> config.QuotaCode <- value)
            ({ assignments = state.assignments } : ServicequotasTemplateState<Present, 'Region, 'ServiceCode, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template#region-1">ServicequotasTemplate#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: ServicequotasTemplateState<'QuotaCode, Missing, 'ServiceCode, 'Value>, value: string) : ServicequotasTemplateState<'QuotaCode, Present, 'ServiceCode, 'Value> =
            state.assignments.Add(fun config -> config.Region <- value)
            ({ assignments = state.assignments } : ServicequotasTemplateState<'QuotaCode, Present, 'ServiceCode, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template#service_code-1">ServicequotasTemplate#service_code</a>.
        /// </summary>
        [<CustomOperation "service_code">]
        member _.ServiceCode(state: ServicequotasTemplateState<'QuotaCode, 'Region, Missing, 'Value>, value: string) : ServicequotasTemplateState<'QuotaCode, 'Region, Present, 'Value> =
            state.assignments.Add(fun config -> config.ServiceCode <- value)
            ({ assignments = state.assignments } : ServicequotasTemplateState<'QuotaCode, 'Region, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_template#value-1">ServicequotasTemplate#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ServicequotasTemplateState<'QuotaCode, 'Region, 'ServiceCode, Missing>, value: double) : ServicequotasTemplateState<'QuotaCode, 'Region, 'ServiceCode, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : ServicequotasTemplateState<'QuotaCode, 'Region, 'ServiceCode, Present>)

        member _.Run(state: ServicequotasTemplateState<Present, Present, Present, Present>) : aws.ServicequotasTemplate.ServicequotasTemplate =
            let config = aws.ServicequotasTemplate.ServicequotasTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.ServicequotasTemplate.ServicequotasTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicequotasTemplate: missing required arguments. Must call: quota_code, region, service_code, value.", 9999, IsError = true)>]
        member _.Run(_: ServicequotasTemplateState<_, _, _, _>) : aws.ServicequotasTemplate.ServicequotasTemplate =
            Unchecked.defaultof<aws.ServicequotasTemplate.ServicequotasTemplate>
