<template>
    <div>
        <todo v-for="todo in todos"
              :description="todo.Description"
              :isComplete="todo.IsComplete"
              :key="todo.id"></todo>
    </div>
</template>

<script>
    import Todo from './Todo.vue'
    export default {
        props: {
            todos: Array
        },
        components: {
            Todo
        }
    }
</script>

<style scoped>
</style>