namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticBeanstalkSolutionStackState<'NameRegex> = { assignments: ResizeArray<aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_solution_stack">aws_elastic_beanstalk_solution_stack</a>.
    /// </summary>
    type DataAwsElasticBeanstalkSolutionStackBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticBeanstalkSolutionStackState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticBeanstalkSolutionStackState<Missing>)

        member _.Zero(()) : DataAwsElasticBeanstalkSolutionStackState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticBeanstalkSolutionStackState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_solution_stack#name_regex-1">DataAwsElasticBeanstalkSolutionStack#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsElasticBeanstalkSolutionStackState<Missing>, value: string) : DataAwsElasticBeanstalkSolutionStackState<Present> =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            ({ assignments = state.assignments } : DataAwsElasticBeanstalkSolutionStackState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_solution_stack#id-1">DataAwsElasticBeanstalkSolutionStack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticBeanstalkSolutionStackState<'NameRegex>, value: string) : DataAwsElasticBeanstalkSolutionStackState<'NameRegex> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticBeanstalkSolutionStackState<'NameRegex>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_solution_stack#most_recent-1">DataAwsElasticBeanstalkSolutionStack#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsElasticBeanstalkSolutionStackState<'NameRegex>, value: bool) : DataAwsElasticBeanstalkSolutionStackState<'NameRegex> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsElasticBeanstalkSolutionStackState<'NameRegex>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_solution_stack#most_recent-1">DataAwsElasticBeanstalkSolutionStack#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsElasticBeanstalkSolutionStackState<'NameRegex>, value: HashiCorp.Cdktf.IResolvable) : DataAwsElasticBeanstalkSolutionStackState<'NameRegex> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsElasticBeanstalkSolutionStackState<'NameRegex>

        member _.Run(state: DataAwsElasticBeanstalkSolutionStackState<Present>) : aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStack =
            let config = aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStackConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticBeanstalkSolutionStack: missing required arguments. Must call: name_regex.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticBeanstalkSolutionStackState<_>) : aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStack =
            Unchecked.defaultof<aws.DataAwsElasticBeanstalkSolutionStack.DataAwsElasticBeanstalkSolutionStack>
