namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, 'Value> = { assignments: ResizeArray<aws.ServicequotasServiceQuota.ServicequotasServiceQuotaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_service_quota">aws_servicequotas_service_quota</a>.
    /// </summary>
    type ServicequotasServiceQuotaBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicequotasServiceQuotaState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicequotasServiceQuotaState<Missing, Missing, Missing>)

        member _.Zero(()) : ServicequotasServiceQuotaState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicequotasServiceQuotaState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_service_quota#quota_code-1">ServicequotasServiceQuota#quota_code</a>.
        /// </summary>
        [<CustomOperation "quota_code">]
        member _.QuotaCode(state: ServicequotasServiceQuotaState<Missing, 'ServiceCode, 'Value>, value: string) : ServicequotasServiceQuotaState<Present, 'ServiceCode, 'Value> =
            state.assignments.Add(fun config -> config.QuotaCode <- value)
            ({ assignments = state.assignments } : ServicequotasServiceQuotaState<Present, 'ServiceCode, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_service_quota#service_code-1">ServicequotasServiceQuota#service_code</a>.
        /// </summary>
        [<CustomOperation "service_code">]
        member _.ServiceCode(state: ServicequotasServiceQuotaState<'QuotaCode, Missing, 'Value>, value: string) : ServicequotasServiceQuotaState<'QuotaCode, Present, 'Value> =
            state.assignments.Add(fun config -> config.ServiceCode <- value)
            ({ assignments = state.assignments } : ServicequotasServiceQuotaState<'QuotaCode, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_service_quota#value-1">ServicequotasServiceQuota#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, Missing>, value: double) : ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicequotas_service_quota#id-1">ServicequotasServiceQuota#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, 'Value>, value: string) : ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicequotasServiceQuotaState<'QuotaCode, 'ServiceCode, 'Value>

        member _.Run(state: ServicequotasServiceQuotaState<Present, Present, Present>) : aws.ServicequotasServiceQuota.ServicequotasServiceQuota =
            let config = aws.ServicequotasServiceQuota.ServicequotasServiceQuotaConfig()
            for setter in state.assignments do
                setter config
            aws.ServicequotasServiceQuota.ServicequotasServiceQuota(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicequotasServiceQuota: missing required arguments. Must call: quota_code, service_code, value.", 9999, IsError = true)>]
        member _.Run(_: ServicequotasServiceQuotaState<_, _, _>) : aws.ServicequotasServiceQuota.ServicequotasServiceQuota =
            Unchecked.defaultof<aws.ServicequotasServiceQuota.ServicequotasServiceQuota>
