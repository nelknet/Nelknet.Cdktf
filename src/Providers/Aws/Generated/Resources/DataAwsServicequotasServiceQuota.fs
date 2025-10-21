namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicequotasServiceQuotaState<'ServiceCode> = { assignments: ResizeArray<aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuotaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service_quota">aws_servicequotas_service_quota</a>.
    /// </summary>
    type DataAwsServicequotasServiceQuotaBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicequotasServiceQuotaState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasServiceQuotaState<Missing>)

        member _.Zero(()) : DataAwsServicequotasServiceQuotaState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasServiceQuotaState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service_quota#service_code-1">DataAwsServicequotasServiceQuota#service_code</a>.
        /// </summary>
        [<CustomOperation "service_code">]
        member _.ServiceCode(state: DataAwsServicequotasServiceQuotaState<Missing>, value: string) : DataAwsServicequotasServiceQuotaState<Present> =
            state.assignments.Add(fun config -> config.ServiceCode <- value)
            ({ assignments = state.assignments } : DataAwsServicequotasServiceQuotaState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service_quota#id-1">DataAwsServicequotasServiceQuota#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicequotasServiceQuotaState<'ServiceCode>, value: string) : DataAwsServicequotasServiceQuotaState<'ServiceCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicequotasServiceQuotaState<'ServiceCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service_quota#quota_code-1">DataAwsServicequotasServiceQuota#quota_code</a>.
        /// </summary>
        [<CustomOperation "quota_code">]
        member _.QuotaCode(state: DataAwsServicequotasServiceQuotaState<'ServiceCode>, value: string) : DataAwsServicequotasServiceQuotaState<'ServiceCode> =
            state.assignments.Add(fun config -> config.QuotaCode <- value)
            state : DataAwsServicequotasServiceQuotaState<'ServiceCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service_quota#quota_name-1">DataAwsServicequotasServiceQuota#quota_name</a>.
        /// </summary>
        [<CustomOperation "quota_name">]
        member _.QuotaName(state: DataAwsServicequotasServiceQuotaState<'ServiceCode>, value: string) : DataAwsServicequotasServiceQuotaState<'ServiceCode> =
            state.assignments.Add(fun config -> config.QuotaName <- value)
            state : DataAwsServicequotasServiceQuotaState<'ServiceCode>

        member _.Run(state: DataAwsServicequotasServiceQuotaState<Present>) : aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuota =
            let config = aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuotaConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuota(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicequotasServiceQuota: missing required arguments. Must call: service_code.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicequotasServiceQuotaState<_>) : aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuota =
            Unchecked.defaultof<aws.DataAwsServicequotasServiceQuota.DataAwsServicequotasServiceQuota>
