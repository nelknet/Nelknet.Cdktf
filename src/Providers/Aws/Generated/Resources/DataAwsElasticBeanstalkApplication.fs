namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticBeanstalkApplicationState<'Name> = { assignments: ResizeArray<aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_application">aws_elastic_beanstalk_application</a>.
    /// </summary>
    type DataAwsElasticBeanstalkApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticBeanstalkApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticBeanstalkApplicationState<Missing>)

        member _.Zero(()) : DataAwsElasticBeanstalkApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticBeanstalkApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_application#name-1">DataAwsElasticBeanstalkApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsElasticBeanstalkApplicationState<Missing>, value: string) : DataAwsElasticBeanstalkApplicationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsElasticBeanstalkApplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_application#id-1">DataAwsElasticBeanstalkApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticBeanstalkApplicationState<'Name>, value: string) : DataAwsElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticBeanstalkApplicationState<'Name>

        member _.Run(state: DataAwsElasticBeanstalkApplicationState<Present>) : aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplication =
            let config = aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticBeanstalkApplication: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticBeanstalkApplicationState<_>) : aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplication =
            Unchecked.defaultof<aws.DataAwsElasticBeanstalkApplication.DataAwsElasticBeanstalkApplication>
