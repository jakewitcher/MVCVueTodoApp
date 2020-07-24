<template>
    <div>
        <p>{{ description }}</p>
    </div>
</template>

<script>
    export default {
        props: {
            description: String,
            isComplete: Boolean
        }
    }
</script>

<style scoped>
    div {
        color: blue;
    }
</style>